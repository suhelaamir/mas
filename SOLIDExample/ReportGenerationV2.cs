using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample
{
    public class ReportGenerateCsv
    {
        protected string connectStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public System.Data.DataTable getEmployeeData()
        {
            System.Data.DataTable empTable = new System.Data.DataTable();
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                string qry = "SELECT * FROM EMPLOYEE";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(empTable);
            }

            return empTable;
        }

        public virtual void generateReport()
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            object misValue = System.Reflection.Missing.Value;
            System.Data.DataTable empTable = getEmployeeData();
            excel = new Microsoft.Office.Interop.Excel.Application();
            // for making Excel visible  
            excel.Visible = false;
            excel.DisplayAlerts = false;
            // Creation a new Workbook  
            excelworkBook = excel.Workbooks.Add(misValue);
            // Workk sheet  
            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
            excelSheet.Name = "Test work sheet";
            excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[empTable.Rows.Count, empTable.Columns.Count]];
            excelCellrange.EntireColumn.AutoFit();
            Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            border.Weight = 2d;
            for (int i = 0; i <= empTable.Rows.Count - 1; i++)
            {
                for (int j = 0; j <= empTable.Columns.Count - 1; j++)
                {
                    string data = empTable.Rows[i].ItemArray[j].ToString();
                    excelSheet.Cells[i + 1, j + 1] = data;
                }
            }

            excelSheet.SaveAs("e:\\Employess.csv", Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue);
            excelworkBook.Close(true, misValue, misValue);
            excel.Quit();

            releaseObject(excelSheet);
            releaseObject(excelworkBook);
            releaseObject(excel);
            Console.WriteLine("Employee data exported to Csv successfully!");
        }
        protected void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                //MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }

        }
    }

    class ExportToPDF : ReportGenerateCsv
    {
        public override void generateReport()
        {
            Console.WriteLine("PDF export code not implemented!");
        }
    }

    class ExportToExcel : ReportGenerateCsv
    {
        public override void generateReport()
        {
            Console.WriteLine("Excel export code not implemented!");
        }
    }

}
