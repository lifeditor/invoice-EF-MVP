using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Invoice
{
    internal interface IEditForm
    {
        BindingSource BindingSource { get; set; }
        BindingSource ArticleBindingSource { get; set; }
        DialogResult FormShow();
        event EventHandler AddClick;
        event EventHandler DeleteClick;
        event EventHandler<CustomEventArgs> InvoiceCheck;
    }

    internal partial class EditForm : Form, IEditForm
    {
        private List<object> articles;

        public EditForm()
        {
            InitializeComponent();
            articles = new List<object>();
        }

        public BindingSource BindingSource
        {
            get { return invoiceBindingSource; }
            set { invoiceBindingSource = value; }
        }

        public BindingSource ArticleBindingSource
        {
            get { return articleBindingSource; }
            set { articleBindingSource = value; }
        }

        public DialogResult FormShow()
        {
            return ShowDialog();
        }

        public event EventHandler AddClick;
        public event EventHandler DeleteClick;
        public event EventHandler<CustomEventArgs> InvoiceCheck;

        private void ClearArticle(object obj)
        {
            if (DeleteClick != null)
                DeleteClick(obj, EventArgs.Empty);

            articleBindingSource.Remove(obj);
        }

        private void EditForm_Shown(object sender, EventArgs e)
        {
            dgvArticleList.DataSource = articleBindingSource;
            dtInvoiceDate.Value = dtInvoiceDate.Value.Date;
            dtOrderDate.Value = dtOrderDate.Value.Date;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            object obj = articleBindingSource.AddNew();
            
            if (AddClick != null)
                AddClick(obj, EventArgs.Empty);

            articles.Add(obj);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (articleBindingSource.Count > 0)
            {
                object obj = articleBindingSource.Current;

                ClearArticle(obj);
                if (articles.Contains(obj))
                    articles.Remove(obj);
            }
        }

        private void dgvArticleList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = false;
        }

        private bool IsValidate()
        {
            bool isValid = true;
            errorProvider.Clear();

            if (eInvoiceNum.TextLength == 0)
            {
                errorProvider.SetError(eInvoiceNum, Constant.msgErrorInvoiceNum);
                isValid = false;
            }
            else if (InvoiceCheck != null)
            {
                CustomEventArgs e = new CustomEventArgs(0);
                InvoiceCheck(invoiceBindingSource.Current, e);
                if (!e.Checked)
                    isValid = false;
            }
            
            return isValid;
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                e.Cancel = !IsValidate();
            }
            else
            {
                foreach (object article in articles)
                    ClearArticle(article);
            }
        }
    }
}
