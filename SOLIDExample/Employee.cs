using Aspose.Cells;
using Aspose.Cells.Tables;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SOLIDExample
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }

        private string connectStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public void insertEmployee(Employee emp)
        {

            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                string qry = string.Format("INSERT INTO EMPLOYEE VALUES('{0}','{1}')",emp.EmpName,emp.Designation);
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteAllEmp()
        {
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                string qry = "TRUNCATE TABLE EMPLOYEE";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
            }
        }

        public void GenerateReport()
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;
            object misValue = System.Reflection.Missing.Value;
            DataTable empTable = new DataTable();
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                string qry = "SELECT * FROM EMPLOYEE";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(empTable);
            }
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


            excelSheet.SaveAs("e:\\informations.csv", Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue);
            excelworkBook.Close(true, misValue, misValue);
            excel.Quit();

            releaseObject(excelSheet);
            releaseObject(excelworkBook);
            releaseObject(excel);
        }

        private void releaseObject(object obj)
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

    public class EmployeeV2
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }

        private string connectStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public void insertEmployee(EmployeeV2 emp)
        {

            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                string qry = string.Format("INSERT INTO EMPLOYEE VALUES('{0}','{1}')", emp.EmpName, emp.Designation);
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
            }
        }

        public void deleteAllEmp()
        {
            using (SqlConnection con = new SqlConnection(connectStr))
            {
                con.Open();
                string qry = "TRUNCATE TABLE EMPLOYEE";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
