using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Invoicing.Forms
{
  public partial class frmDodavatele : _frmDefault
  {

    public int idDodavatel;
    public frmDodavatele()
    {
      InitializeComponent();
    }

    private void frmDodavatele_Load(object sender, EventArgs e)
    {
      LoadDodavatele();
    }

    private void LoadDodavatele()
    {
      lbDodavatele.DataSource = DB.GetFirms();
      lbDodavatele.DisplayMember = "Name";
      lbDodavatele.ValueMember = "idFirm";
      lbDodavatele.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (1 == DB.NewFirm(txtName.Text, txtIco.Text, txtDIC.Text, txtAdress.Text, txtZipCode.Text, txtCity.Text))
        LoadDodavatele();
      else
      {
        MessageBox.Show(DB.sErr);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      Vybrano();
    }

    private void lbDodavatele_DoubleClick(object sender, EventArgs e)
    {
      Vybrano();
    }

    private void Vybrano()
    {
      idDodavatel = (int)lbDodavatele.SelectedValue;
      this.DialogResult = System.Windows.Forms.DialogResult.Yes;
    }

    private void lbDodavatele_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnSearchARES_Click(object sender, EventArgs e)
    {
      string Ico = "";
      string Dic = "";
      string Name = "";
      string Address = "";
      string ZipCode= "";
      string City = "";
      string ErrString = "";
      string responseFromServer;


      // http://wwwinfo.mfcr.cz/ares/ares_xml.html.cz#k1
      // http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_bas.cgi?ico=27389731
      try
      {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_bas.cgi?ico="+txtIco.Text);
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://google.com");
        ((HttpWebRequest)request).UserAgent = "ALEX TRADE";
        WebResponse response = request.GetResponse();
        Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        responseFromServer = reader.ReadToEnd();
        response.Close();
      }

        //       XmlDocument xmlDoc = new XmlDocument();
        //       xmlDoc.LoadXml(responseFromServer);

        /* string xpath = "/Ares_odpovedi /namespace:are";
         var x1 = xmlDoc.SelectNodes(xpath);

         foreach (XmlNode childrenNode in nodes)
         {
         }
         */
      catch (Exception Ex)
      {
        MessageBox.Show(Ex.Message, "ARES -- Chyba spojení se serverem wwwinfo.mfcr.cz");
        return;
      }
       XmlReader rdr = XmlReader.Create(new StringReader(responseFromServer));
        while (rdr.Read())
        {
          if (rdr.NodeType == XmlNodeType.Element)
          {
            if (rdr.LocalName.CompareTo("ET") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              ErrString = rdr.Value;
            }
            if (rdr.LocalName.CompareTo("ICO") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              Ico = rdr.Value;
            } if (rdr.LocalName.CompareTo("DIC") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              Dic = rdr.Value;
            }
            if (rdr.LocalName.CompareTo("OF") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              Name = rdr.Value;
            }
            if (rdr.LocalName.CompareTo("UC") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              Address = rdr.Value;
            }
            if (rdr.LocalName.CompareTo("PSC") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              ZipCode = rdr.Value;
            }
            if (rdr.LocalName.CompareTo("N") == 0 && rdr.Prefix.CompareTo("D") == 0)
            {
              rdr.Read();
              City = rdr.Value;
            }
          }
        }
       if (ErrString.Length > 0)
        MessageBox.Show(ErrString,"Chyba ARES - Nenalezeno");
      else { 
        txtName.Text = Name;
        txtDIC.Text = Dic;
        txtCity.Text = City;
        txtZipCode.Text = ZipCode;
        txtAdress.Text = Address;
      }
    }
  }
}
