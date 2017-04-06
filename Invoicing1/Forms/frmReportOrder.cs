using Invoicing.Modul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing.Forms
{
  public partial class frmReportOrder : _frmDefault
  {
    public frmReportOrder()
    {
      InitializeComponent();
    }

    private void frmReportOrder_Load(object sender, EventArgs e)
    {
      this.Text = "Report Order  -  " + ActiveOrder.OrderName;
    }


    /*
     SELECT ItemName, Quantity, UnitShort, ROUND(BasePriceBezDPH,2), PairType, PairPrice, Rozdil, PairWeek
  FROM [SSCP].[dbo].[wPair]
  WHERE idOrder = 1011
ORDER BY PairWeek,ItemName */
    private void btnReport1_Click(object sender, EventArgs e)
    {
      List<wPair> PairItems = DB.GetPairForOrder(ActiveOrder.idOrder);
      DataTable dt = new DataTable();
      dt.Columns.Add("Název");
      dt.Columns.Add("Množství");
      dt.Columns.Add("Jednotka");
      dt.Columns.Add("Cena");
      dt.Columns.Add("CenaCelkem");
      dt.Columns.Add("Typ Párování");
      dt.Columns.Add("Nejnižší Cena");
      dt.Columns.Add("Rozdíl");
      dt.Columns.Add("Týden");
      foreach (var item in PairItems) {
        dt.Rows.Add(item.ItemName
          , item.Quantity
          , item.UnitShort
          , Helper.DoubleToString(item.BasePriceBezDPH)
          , Helper.DoubleToString(item.PriceBezDPH)
          , item.PairType
          , Helper.DoubleToString(item.PairPrice)
          , item.Rozdil
          , item.PairWeek
        );
      }
      dt.ExportToExcel(null, true);
    }
  }
}
