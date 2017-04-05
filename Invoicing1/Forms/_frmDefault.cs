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
  public partial class _frmDefault : Form
  {
    public CDatabase DB;
    public CUser LoginUser;
    public wOrders ActiveOrder;
    public _frmDefault()
    {
      InitializeComponent();
    }

    private void _frmDefault_Load(object sender, EventArgs e)
    {
      Font myfont = new Font("Times New Roman", 12.0f);
      foreach (var c in this.Controls)
      {
        if (c is TextBox)
        {
          ((TextBox)c).Font = myfont;
        }
        if (c is DateTimePicker)
        {
          ((DateTimePicker)c).Font = myfont;
        }
        if (c is ComboBox)
        {
          ((ComboBox)c).Font = myfont;
        }
      }
      RefreshPanel();

    }

    public  void RefreshPanel() {
      DB = Program.DB;
      LoginUser = Program.LoginUser;
      ActiveOrder = Program.ActiveOrder;
    }
  }
}
