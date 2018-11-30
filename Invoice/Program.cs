using System;
using System.Windows.Forms;
using Invoice.Model;

namespace Invoice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            DBManager manager = new DBManager();
            MessageService messageService = new MessageService();
            MainPresenter presenter = new MainPresenter(form, manager, messageService);

            Application.Run(form);
        }
    }
}
