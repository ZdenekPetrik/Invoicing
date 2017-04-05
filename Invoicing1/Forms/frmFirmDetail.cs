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
  public partial class frmFirmDetail : _frmDefault
  {
    public wFirms Firma;
    public frmFirmDetail()
    {
      InitializeComponent();
    }




    private void frmFirmDetail_Load(object sender, EventArgs e)
    {
      if (Firma == null)
      {
        MessageBox.Show("F == null");
        return;
      }
      txtName.Text = Firma.Name;
      txtIco.Text = Firma.Ic;
      txtDIC.Text = Firma.Dic;
      txtAdress.Text = Firma.Adress;
      txtZipCode.Text = Firma.ZipCode;
      txtCity.Text = Firma.City;
      CAres Ares = new CAres();
   /*   if (Ares.GetAres(txtIco.Text))
      {
        txtAresName.Text = Ares.Name;
        txtAresIco.Text = Ares.Ico;
        txtAresDic.Text = Ares.Dic;
        txtAresAdresa.Text = Ares.Address;
        txtAresZipCode.Text = Ares.ZipCode;
        txtAresCity.Text = Ares.City;
      }
      else
      {
        txtAresName.Text = Ares.ErrString;
      }
   */   List<FirmCategory> dbFirmCat = DB.GetFirmCategory().FindAll(X => X.idMainFirmCategory == 1);    // 1 = Dodavatele
      cbFirmCategory.DataSource = dbFirmCat;
      cbFirmCategory.DisplayMember = "Category";
      cbFirmCategory.ValueMember = "idFirmCategory";
      if (Firma.idFirmCategory == null)
        cbFirmCategory.SelectedValue = 5;
      else
        cbFirmCategory.SelectedValue = Firma.idFirmCategory;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (txtName.Text != Firma.Name ||
              txtDIC.Text != Firma.Dic ||
              txtAdress.Text != Firma.Adress ||
              txtZipCode.Text != Firma.ZipCode ||
              txtCity.Text != Firma.City ||
              Firma.idFirmCategory != (int?)cbFirmCategory.SelectedValue)
      {
        if (DialogResult.Yes == MessageBox.Show("Opravdu změnit údaje pro firmu?", "Změna", MessageBoxButtons.YesNo))
        {
          Firma.Name = txtName.Text;
          Firma.Dic = txtDIC.Text;
          Firma.Adress = txtAdress.Text;
          Firma.ZipCode = txtZipCode.Text;
          Firma.City = txtCity.Text;
          Firma.idFirmCategory = (int)cbFirmCategory.SelectedValue;
          DB.FirmUpdate(Firma);
          this.DialogResult = System.Windows.Forms.DialogResult.Yes;
          return;
        }
        else
        {
          return;
        }
      }
      this.DialogResult = System.Windows.Forms.DialogResult.No;
    }
  }
}
