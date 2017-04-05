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
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private void Menu_OrderNew_Click(object sender, EventArgs e)
    {

    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      statusStrip1.Text = "Verze " + Application.ProductVersion.ToString();
      Program.LoginUser = new AlexLib.CUser();
      Program.LoginUser.getUser(Environment.UserName, "");
    }


    #region Menu
    private void Menu_OrderChange_Click(object sender, EventArgs e)
    {

    }
    #endregion

  }
}
