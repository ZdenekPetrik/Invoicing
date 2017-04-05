using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;



namespace Invoicing
{
  public class CMainEventLog
  {

    public string ConnectionString {get;set;}
    private string _applicationName;
    public string ApplicationName {
      get
      {
        if (_applicationName == null)
        {
          _applicationName = System.Configuration.ConfigurationSettings.AppSettings["AppName"];
          if (_applicationName == null)
            _applicationName = "<Unknown>";
        }
        return _applicationName;
      }
      set { _applicationName = value; } 
    }
    public string LoginUser1;

    public CMainEventLog() {
      LoginUser1 = "";
     // ConnectionString = ConfigurationManager.AppSettings["SelfiConnectionString"];
     // private string SQLConnectionString = ConfigurationManager.AppSettings["SQlConnectionString"];
    }

    public CMainEventLog(EventCode eventCode, EventSubCode eventSubCode, string Text)
      : this()
    {
      WriteMainEventLog(eventCode, eventSubCode, Text);
    }

    public CMainEventLog(EventCode eventCode, EventSubCode eventSubCode, string Text, string Value)
      : this()
    {
      WriteMainEventLog(eventCode, eventSubCode, Text, Value);
    }

    public CMainEventLog(EventCode eventCode, EventSubCode eventSubCode, string Text, string Value, string sUserId)
      : this()
    {
      WriteMainEventLog(eventCode, eventSubCode, Text, Value, sUserId);
    }

    public enum EventCode
    {
      e1Program = 100,
      e1Login = 102,
      e1Message = 103,
      e1Debug = 104,
      e1Invoice = 105,
      e1Expenditure = 106,
      e1CheckSum = 107
    };
    public enum EventSubCode
    {
      e2Start = 1,
      e2Stop,
      e2Error,
      e2Warning,
      e2Info,
      e2BadLogin,

      // e1Invoice
      e2Create,
      e2AddOrder,
      e2RemoveOrder,
      e2Remove,
      e2Modify,
      // e1Expenditure
      e2SecondsOrMore,     // druha a dalsi objednávka k případu se nepřenáší
      e2ManualAdd,        // manuální přidání Expenditure
      e2ParujAdd,         // Parovani Expenditure s Objednavkou
      e2ParujRemove,      // Odstraneni Parovani 
      e2Parovani,         // Pro detail chyby
      e2UnityState        // Změna stavu APPROVE/CLOSE v UNITY není možná
    };

    public void WriteMainEventLog(string Text) {
      WriteMainEventLog(EventCode.e1Message, EventSubCode.e2Info, Text);
    }

    public void WriteMainEventLog(EventCode e1, EventSubCode e2, string Text)
    {
      WriteMainEventLog(DateTime.Now, e1, e2, Text, "");
    }

    public void WriteMainEventLog(EventCode e1, EventSubCode e2, string Text, string Value)
    {
      WriteMainEventLog(DateTime.Now, e1, e2, Text, Value);
    }


    public void WriteMainEventLog(DateTime dtEvent, EventCode e1, EventSubCode e2, string Text, string Value)
    {
      if (ConnectionString == null)
        ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["SelfiConnectionString"];
      SqlConnection connection = new SqlConnection(ConnectionString);
      try
      {
        string queryString = "INSERT Selfi.dbo.MainEventLog ([CreateDate],[Program],[LoginUser],[eventType],[eventSubType],[Text],[Value]) VALUES (@CreateDate,@Program,@LoginUser,@eventType,@eventSubType,@Text,@Value)";
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Connection.Open();
        command.Parameters.AddWithValue("@CreateDate", dtEvent);
        AddParams(command.Parameters, "@LoginUser", LoginUser1, 50);
        AddParams(command.Parameters, "@Program", ApplicationName, 50);
        command.Parameters.AddWithValue("@eventType", e1);
        command.Parameters.AddWithValue("@eventSubType", e2);
        AddParams(command.Parameters, "@Text", Text, 4000);
        AddParams(command.Parameters, "@Value", Value, 100);
        command.ExecuteNonQuery();
      }
      catch (Exception Ex)
      {
        // Co proboha udelat pokud selze log
      }
      finally
      {
        connection.Close();
      }

    }

    public void WriteMainEventLog(EventCode e1, EventSubCode e2, string Text, string Value, string LoginUserId) {
      WriteMainEventLog(DateTime.Now, e1, e2, Text, Value, LoginUserId);
    }

    public void WriteMainEventLog(DateTime dtEvent, EventCode e1, EventSubCode e2, string Text, string Value, string LoginUserId )
    {
      if (ConnectionString == null)
        ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["SelfiConnectionString"];
      SqlConnection connection = new SqlConnection(ConnectionString);
      try
      {
        string queryString = "INSERT Selfi.dbo.MainEventLog ([CreateDate],[Program],[LoginUser],[eventType],[eventSubType],[Text],[Value]) VALUES (@CreateDate,@Program,@LoginUser,@eventType,@eventSubType,@Text,@Value)";
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Connection.Open();
        command.Parameters.AddWithValue("@CreateDate", dtEvent);
        AddParams(command.Parameters, "@LoginUser", LoginUserId, 50);
        AddParams(command.Parameters, "@Program", ApplicationName, 50);
        command.Parameters.AddWithValue("@eventType", e1);
        command.Parameters.AddWithValue("@eventSubType", e2);
        AddParams(command.Parameters, "@Text", Text, 4000);
        AddParams(command.Parameters, "@Value", Value, 100);
        command.ExecuteNonQuery();
      }
      catch (Exception Ex)
      {
        // Co proboha udelat pokud selze log
      }
      finally
      {
        connection.Close();
      }

    }

    private void AddParams(SqlParameterCollection sqlParameterCollection, string Nazev, string Value, int Size)
    {
      if (Value != null && Value.Length > Size)
        Value = Value.Substring(0, Size - 3) + "...";
      sqlParameterCollection.Add(Nazev, SqlDbType.NVarChar, Size).Value = Value;
    }

    public DateTime GetLastStartOfSelfiService()
    {
      if (ConnectionString == null)
        ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["SelfiConnectionString"];
      SqlConnection connection = new SqlConnection(ConnectionString);
      try
      {
        string queryString = "SELECT TOP 1 CreateDate FROM  [SelfI].[dbo].[MainEventLog] WHERE Program = 'SelfiService' And EventType = 100 And EventSubType = 1 ORDER BY ID DESC";
        SqlCommand command = new SqlCommand(queryString, connection);
        command.Connection.Open();
        object O = command.ExecuteScalar();
        return (DateTime)O;
      }
      catch (Exception Ex)
      {
        // Co proboha udelat pokud selze log
      }
      finally
      {
        connection.Close();
      }
      return DateTime.MinValue;
    }
  }
}
