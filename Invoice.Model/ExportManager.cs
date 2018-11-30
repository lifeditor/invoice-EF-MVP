using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Data.EntityClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.Objects;
using System.ComponentModel;

namespace Invoice.Model
{
    public static class ExportManager
    {
        private const byte percentageComplete = 100;
        private const byte percentageHalf = 50;

        public static void EntityToExcel(string template, string excelFileName, IQueryable query, ObjectContext context, object bgWorker)
        {
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            Excel.Range range = null;

            BackgroundWorker bW = (BackgroundWorker)bgWorker;
            bW.ReportProgress(percentageHalf);
            
            try
            {
                excelApp = new Excel.Application();

                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;
                wb = excelApp.Workbooks.Add(template);
                ws = (Excel.Worksheet)wb.ActiveSheet;
                Excel.Names names = wb.Names;

                DataSet ds = EntityToDataSet(query, context);

                int tableCount = ds.Tables.Count;
                foreach (DataTable dt in ds.Tables)
                {

                    int rowCount = 0;
                    int rows = dt.Rows.Count;
                    
                    foreach (DataRow row in dt.Rows)
                    {
                        rowCount++;
                        foreach (DataColumn column in dt.Columns)
                        {
                            foreach (Excel.Name name in names)
                            {
                                if (name.Name.ToUpper() == column.ColumnName.ToUpper())
                                {
                                    range = (Excel.Range)ws.get_Range(name);
                                    range.Value = row[column.ColumnName];
                                    break;
                                }
                             }
                        }
                        if (rows > 1 && rowCount < rows)
                        {
                            range = range.EntireRow;
                            range.Insert(Excel.XlInsertShiftDirection.xlShiftDown, true);
                            Excel.Range destRange = (Excel.Range)ws.Rows[range.Row - 1];
                            range.Copy(destRange);
                            destRange = null;
                        }
                    }
                    bW.ReportProgress(percentageComplete / (tableCount)--);
                }

                names = null;

                wb.SaveAs(excelFileName,
                           Excel.XlFileFormat.xlWorkbookNormal,
                           Type.Missing,
                           Type.Missing,
                           Type.Missing,
                           Type.Missing,
                           Excel.XlSaveAsAccessMode.xlExclusive,
                           Type.Missing,
                           Type.Missing,
                           Type.Missing,
                           Type.Missing);

                wb.Close(Type.Missing, Type.Missing, Type.Missing);
                excelApp.Quit();
                range = null;
                ws = null;
                wb = null;
                excelApp = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static DataSet EntityToDataSet(IQueryable source, ObjectContext context)
        {
            try
            {
                EntityConnection conn = context.Connection as EntityConnection;
                using (SqlConnection SQLCon = new SqlConnection(conn.StoreConnection.ConnectionString))
                {
                    ObjectQuery query = source as ObjectQuery;
                    using (SqlCommand Cmd = new SqlCommand(query.ToTraceString(), SQLCon))
                    {
                        foreach (var param in query.Parameters)
                        {
                            Cmd.Parameters.AddWithValue(param.Name, param.Value);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(Cmd))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                DataTable dt = ds.Tables.Add();
                                da.Fill(dt);
                                return ds;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
