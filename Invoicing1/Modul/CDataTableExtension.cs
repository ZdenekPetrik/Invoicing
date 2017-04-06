using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Modul
{
   public static class CDataTableExtension
  {

    /// <summary>
    /// Export DataTable to Excel file
    /// </summary>
    /// <param name="DataTable">Source DataTable</param>
    /// <param name="ExcelFilePath">Path to result file name</param>
    public static void ExportToExcel(this System.Data.DataTable DataTable, string ExcelFilePath, bool IsShow)
    {
      try
      {
        int ColumnsCount;

        if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
          throw new Exception("ExportToExcel: Null or empty input table!\n");

        // load excel, and create a new workbook
        Microsoft.Office.Interop.Excel.Application Excl = new Microsoft.Office.Interop.Excel.Application();
        Excl.Workbooks.Add();

        // single worksheet
        Microsoft.Office.Interop.Excel._Worksheet Worksheet = (Microsoft.Office.Interop.Excel._Worksheet)Excl.ActiveSheet;

        object[] Header = new object[ColumnsCount];

        // column headings               
        for (int i = 0; i < ColumnsCount; i++)
          Header[i] = DataTable.Columns[i].ColumnName;

        Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
        HeaderRange.Value = Header;
        HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
        HeaderRange.Font.Bold = true;

        // DataCells
        int RowsCount = DataTable.Rows.Count;
        object[,] Cells = new object[RowsCount, ColumnsCount];

        for (int j = 0; j < RowsCount; j++)
          for (int i = 0; i < ColumnsCount; i++)
            Cells[j, i] = DataTable.Rows[j][i];

        Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

        // check fielpath
        if (ExcelFilePath != null && ExcelFilePath != "")
        {
          try
          {
            Worksheet.SaveAs(ExcelFilePath);
            if (!IsShow)
            {
              Excl.Quit();
//              MessageBox.Show("Excel file " + ExcelFilePath + " saved!");
            }
          }
          catch (Exception ex)
          {
            throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                + ex.Message);
          }
        }
        if (IsShow)
        {
          Excl.Visible = true;
        }
      }
      catch (Exception ex)
      {
        throw new Exception("ExportToExcel: \n" + ex.Message);
      }
    }
  }


}
