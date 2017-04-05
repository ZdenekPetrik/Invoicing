using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicing.Modul;

namespace Invoicing.Controls
{
  public partial class ctrlShowOrder : _ctrlDefault
  {
    public ctrlShowOrder()
    {
      InitializeComponent();
    }

    private void ctrlShowOrder_Load(object sender, EventArgs e)
    {
      RefreshData();
    }

    public void RefreshData() {
      base.RefreshPanel();
      if (ActiveOrder == null)
        return;
      lblName.Text = ActiveOrder.OrderName;
      lblInfo.Text = ActiveOrder.FirmName + " " + ActiveOrder.City + "      " + (ActiveOrder.OrderDate ?? DateTime.Now).ToString("MM yyyy");
      lblState.Text = ActiveOrder.StateValueDescription;
      if (ActiveOrder.MaxStateValue == (int)CDatabase.eOrderState.F1_New)
      {
        if (ActiveOrder.NrSCAN > 0)
        {
          List<ScanPDFs> lPDF = DB.GetScanPDFs(ActiveOrder.idOrder, -1, -1);
          lblStatus.Text = "  Scan: " + lPDF.Count().ToString() + "/" + ActiveOrder.NrSCAN.ToString() + " ( " + ((((float)lPDF.Count()) / ((float)ActiveOrder.NrSCAN)) *100).ToString("F0") + " %)";
        }
        lblState.ForeColor = System.Drawing.Color.BlueViolet;
 
      }
    }

    }
}
