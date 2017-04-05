using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicing.Modul;

namespace Invoicing.Forms
{
  public partial class frmFindOrder : _frmDefault
  {
    public frmFindOrder()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (Program.idActiveOrder != (int)lbOrder.SelectedValue)
      {
        ChangeOrder();
      }
      else {
        this.DialogResult = System.Windows.Forms.DialogResult.No;
      }

    }

    private void ChangeOrder()
    {
      Program.idActiveOrder = (int)lbOrder.SelectedValue;
      Program.ActiveOrder = DB.GetOrder(Program.idActiveOrder);
      this.DialogResult = System.Windows.Forms.DialogResult.Yes;
    }

    private void frmFindOrder_Load(object sender, EventArgs e)
    {
      List<wOrders> OrdList = DB.GetOrders();
      List<myOrderItems> lbList = new List<myOrderItems>();
      foreach (wOrders Ord in OrdList){
        myOrderItems lbOrd = new myOrderItems();
        lbOrd.Text = Helper.DateToMonthYear(Ord.OrderDate) + " - " + Ord.OrderName + " " + Ord.FirmName;
        lbOrd.idOrder = Ord.idOrder;
        lbList.Add(lbOrd); 
      }
      lbOrder.DataSource = lbList;
      lbOrder.DisplayMember = "Text";
      lbOrder.ValueMember = "idOrder";
      lbOrder.SelectedValue = ActiveOrder.idOrder;
    }

    private void lbOrder_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (lbOrder.SelectedItem != null)
      {
        ChangeOrder();
      }
    }    
  }
  internal class myOrderItems
  {
    public int idOrder { get; set; }
    public string Text { get; set; }
  }

}
