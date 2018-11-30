namespace Invoice
{
    public static class Constant
    {
        public const int actionCreate = 0;
        public const int actionEdit = 1;

        public const string msgDeletePrompt = "Действительно удалить?";
        public const string msgExportComplete = "Данные экспортированы в файл ";
        public const string msgErrorInvoiceNum = "Пустой номер счета-фактуры недопустим";
        public const string msgErrorInvoiceNumDate = "Невозможно сохранить счет-фактуру! Счет-фактура с таким номером и датой уже существует!";

        public const string dirTemplate = "template";
        public const string dirExcelExport = "XLReports";

        public const string templateInvoice = "xlBlankInvoice.xls";

        public const byte percentageComplete = 100;
        public const byte percentageHalf = 50;
    }

}
