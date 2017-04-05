using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Invoicing.Modul
{
  class CAres
  {

    public string Ico = "";
    public string Dic = "";
    public string Name = "";
    public string Address = "";
    public string ZipCode = "";
    public string City = "";
    public string ErrString = "";
    public string responseFromServer;


    public bool GetAres(string SearchIco)
    {
      try
      {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://wwwinfo.mfcr.cz/cgi-bin/ares/darv_bas.cgi?ico=" + SearchIco);
        //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://google.com");
        ((HttpWebRequest)request).UserAgent = "ALEX TRADE SSCP";
        WebResponse response = request.GetResponse();
        Console.WriteLine(((HttpWebResponse)response).StatusDescription);
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        responseFromServer = reader.ReadToEnd();
        response.Close();
      }
      catch (Exception Ex)
      {
        ErrString = Ex.Message;
        return false;
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
        return false;
      else
        return true;
    }
  }
}
