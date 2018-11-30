using System;
using System.Linq;
using Invoice.Model;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;


namespace Invoice
{
    internal class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IDBManager _manager;
        private readonly IMessageService _message;

        internal MainPresenter(IMainForm view, IDBManager manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _message = messageService;

            try
            {
                _view.BindingSource.DataSource = _manager.GetData();
                _view.EditClick += new EventHandler<CustomEventArgs>(_view_EditClick);
                _view.DeleteClick += new EventHandler(_view_DeleteClick);
                _view.ExportClick += new EventHandler(_view_ExportClick);
            }
            catch (Exception ex)
            {
                _message.ShowError(ex.InnerException.Message);
            }
        }

        private void _view_EditClick(object sender, CustomEventArgs e)
        {
            using (EditForm editor = new EditForm())
            {
                try
                {
                    if (e.Tag == Constant.actionCreate)
                    {
                        object invoice = _view.BindingSource.AddNew();
                        _view.BindingSource.Position = _view.BindingSource.IndexOf(invoice);
                    }

                    editor.BindingSource.DataSource = _view.BindingSource.Current;
                    editor.ArticleBindingSource.DataSource = _manager.GetArticleData(_view.BindingSource.Current);
                    editor.AddClick += new EventHandler(Editor_AddClick);
                    editor.DeleteClick += new EventHandler(Editor_DeleteClick);
                    editor.InvoiceCheck += new EventHandler<CustomEventArgs>(Editor_InvoiceCheck);

                    if (editor.FormShow() == DialogResult.OK)
                    {
                        _view.BindingSource.EndEdit();
                        _manager.SaveData();
                    }
                    else
                    {
                        _view.BindingSource.CancelEdit();
                        _manager.RefreshData();
                    }
                }
                catch (Exception ex)
                {
                    _message.ShowError(ex.Message);
                }
            }
        }

        private void _view_DeleteClick(object sender, EventArgs e)
        {
            if (_message.ShowDialog(Constant.msgDeletePrompt) == DialogResult.No)
                return;
            try
            {
                _view.BindingSource.RemoveCurrent();
                _manager.SaveData();
            }
            catch (Exception ex)
            {
                _message.ShowError(ex.InnerException.Message);
            }
        }

        private void Editor_InvoiceCheck(object sender, CustomEventArgs e)
        {
            e.Checked = _manager.CheckInvoice(sender);
            if (!e.Checked)
                _message.ShowExclamation(Constant.msgErrorInvoiceNumDate);
        }

        private void Editor_AddClick(object sender, EventArgs e)
        {
            _manager.AddArticle(sender, _view.BindingSource.Current);
        }

        private void Editor_DeleteClick(object sender, EventArgs e)
        {
            _manager.DeleteArticle(sender);
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                _message.ShowError(e.Error.Message);

            _view.ProgressInfoValue = 0;
        }

        private void Bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _view.ProgressInfoValue = e.ProgressPercentage;
        }

        private void DoExportTask(string template, string fileName, IQueryable query)
        {
            using (BackgroundWorker bw = new BackgroundWorker())
            {
                bw.WorkerReportsProgress = true;
                bw.ProgressChanged += new ProgressChangedEventHandler(Bw_ProgressChanged);
                bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_RunWorkerCompleted);

                bw.DoWork += (bgWorker, e) =>
                    {
                        ExportManager.EntityToExcel(template, fileName, query, _manager.Context, bgWorker);
                        _message.ShowMessage(string.Format("{0}{1}", Constant.msgExportComplete, fileName));
                    };
                bw.RunWorkerAsync();
            }
        }

        private void _view_ExportClick(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            string exportPath = Path.Combine(startupPath, Constant.dirExcelExport);
            string templatePath = Path.Combine(startupPath, Constant.dirTemplate, Constant.templateInvoice);            
            string fileName = Path.Combine(exportPath, string.Format("inv_{0:yyyyMMdd_HHmmss}.xls", DateTime.Now));

            if (!Directory.Exists(exportPath))
                Directory.CreateDirectory(exportPath);

            DoExportTask(templatePath, fileName, _manager.ObjectToQuery(_view.BindingSource.Current));
        }
    }
}
