using System;
using System.Linq;
using System.Data.Objects;

namespace Invoice.Model
{
    public interface IDBManager
    {
        invoiceDBEntities Context { get; }
        object GetData();
        object GetArticleData(object obj);
        void RefreshData();
        void SaveData();
        IQueryable ObjectToQuery(object obj);
        void AddArticle(object obj, object invoice);
        void DeleteArticle(object obj);
        bool CheckInvoice(object obj);
    }

    public class DBManager: IDBManager
    {
        private readonly invoiceDBEntities _context;

        public DBManager()
        {
            _context = new invoiceDBEntities();
        }

        public invoiceDBEntities Context
        {
            get { return _context; }
        }

        public object GetData()
        {
            return _context.Invoices;
        }

        public object GetArticleData(object obj)
        {
            return ((Model.Invoice)obj).Articles.ToList();
        }

        public void RefreshData()
        {
            _context.Refresh(RefreshMode.StoreWins, _context.Articles);
            _context.Refresh(RefreshMode.StoreWins, _context.Invoices);            
        }

        public void SaveData()
        {
            _context.SaveChanges();
        }

        public IQueryable ObjectToQuery(object obj)
        {
            return _context.Invoices.Include("Articles")
                .Where(e => e.Id == ((Model.Invoice)obj).Id).AsQueryable();
        }

        public void AddArticle(object obj, object invoice)
        {
            ((Model.Article)obj).InvoiceId = ((Model.Invoice)invoice).Id;
            _context.Articles.AddObject((Model.Article)obj);
        }

        public void DeleteArticle(object obj)
        {
            _context.Articles.DeleteObject((Model.Article)obj);
        }

        public bool CheckInvoice(object obj)
        {
            int count = _context.Invoices
                .Where(e => e.InvoiceNum == ((Model.Invoice)obj).InvoiceNum &&
                       e.InvoiceDate == ((Model.Invoice)obj).InvoiceDate &&
                       e.Id != ((Model.Invoice)obj).Id
                       ).Count();

            return count == 0;
        }
    }
}
