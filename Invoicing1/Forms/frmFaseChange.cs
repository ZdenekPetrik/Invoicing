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
  public partial class frmFaseChange : _frmDefault
  {
    public frmFaseChange()
    {
      InitializeComponent();
    }


 
    private void btnTest_Click(object sender, EventArgs e)
    {

    }

    public int Fase { get; set; }

    private void frmFaseChange_Load(object sender, EventArgs e)
    {
      btnFaze.Enabled = false;
      panelFaze12.Visible = false;
      panelFaze23.Visible = false;
      panelFaze34.Visible = false;
      txtProtokol.Height = btnFaze.Top + btnFaze.Height;
      if (Fase == 1){
        panelFaze12.Visible = true;
        panelFaze12.Left = 2;
        panelFaze12.Top = ctrlShowOrder1.Height + 30;
        if (ActiveOrder.MaxStateValue == 1) {
          btnFaze.Enabled = true;
        }else{
          txtProtokol.Text = "Objednávka není ve fázi 1";      
        }
      }
      else if (Fase == 2)
      {
        panelFaze23.Visible = true;
        panelFaze23.Left = 2;
        panelFaze23.Top = ctrlShowOrder1.Height + 30;
        if (ActiveOrder.MaxStateValue == 2)
        {
          btnFaze.Enabled = true;
        }
        else
        {
          txtProtokol.Text = "Objednávka není ve fázi 2";
        }
      }
      else if (Fase == 3)
      {
        panelFaze34.Visible = true;
        panelFaze34.Left = 2;
        panelFaze34.Top = ctrlShowOrder1.Height + 30;
        if (ActiveOrder.MaxStateValue == 3)
        {
          btnFaze.Enabled = true;
        }
        else
        {
          txtProtokol.Text = "Objednávka není ve fázi 3";
        }
      }
      else {
        MessageBox.Show("Tyto fáze ještě neumím");
      }
    }


    private void TestFaze12()
    {

    }
    private void TestFaze23()
    {

    }
  }
}
