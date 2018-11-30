using System;
using System.Windows.Forms;

namespace Invoice
{
    internal interface IMainForm
    {
        BindingSource BindingSource { get; set; }
        int ProgressInfoValue { set; }
        event EventHandler<CustomEventArgs> EditClick;
        event EventHandler DeleteClick;
        event EventHandler ExportClick;
    }

    internal partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            menuNew.Click += new EventHandler(HandlerNewClick);
            menuEdit.Click += new EventHandler(HandlerEditClick);
            menuDelete.Click += new EventHandler(HandlerDeleteClick);
            cnEdit.Click += new EventHandler(HandlerEditClick);
            cnExport.Click += new EventHandler(HandlerExportClick);
            cnDelete.Click +=new EventHandler(HandlerDeleteClick);
            btnCreate.Click += new EventHandler(HandlerNewClick);
            btnEdit.Click += new EventHandler(HandlerEditClick);
            btnDelete.Click += new EventHandler(HandlerDeleteClick);
            btnPrint.Click += new EventHandler(HandlerExportClick);
        }

        public BindingSource BindingSource
        {
            get { return invoiceBindingSource; }
            set { invoiceBindingSource = value; }
        }

        public int ProgressInfoValue
        {
            set { progressBar.Value = value; }
        }

        public event EventHandler<CustomEventArgs> EditClick;
        public event EventHandler DeleteClick;
        public event EventHandler ExportClick;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            dgvInvoiceList.DataSource = BindingSource;
        }

        private void HandlerDeleteClick(object sender, EventArgs e)
        {
            if (DeleteClick != null)
                DeleteClick(this, EventArgs.Empty);
        }

        private void HandlerExportClick(object sender, EventArgs e)
        {
            if (ExportClick != null)
                ExportClick(this, EventArgs.Empty);
        }

        private void HandlerNewClick(object sender, EventArgs e)
        {
            if (EditClick != null)
                EditClick(this, new CustomEventArgs(Constant.actionCreate));
        }

        private void HandlerEditClick(object sender, EventArgs e)
        {
            if (EditClick != null)
                EditClick(this, new CustomEventArgs(Constant.actionEdit));
        }

        private void dgvInvoiceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EditClick != null && e.RowIndex >= 0)
                EditClick(this, new CustomEventArgs(Constant.actionEdit));
        }
    }
}
