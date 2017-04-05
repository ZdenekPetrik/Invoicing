using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing
{
  class CDatabase
  {
    public alextradeEntities db;
    private string _applicationName;
    private int _idUser;
    public string ApplicationName
    {
      get
      {
        if (_applicationName == null)
          _applicationName = System.Configuration.ConfigurationSettings.AppSettings["AppName"];
        return _applicationName;
      }
      set
      {
        _applicationName = value;
      }

    }
    public int IdUser
    {
      get { return _idUser; }
      set { _idUser = value; }
    }

    public CDatabase(int idUser, string ApplicationName)
      : this(idUser)
    {
      this.ApplicationName = ApplicationName;
    }

    public CDatabase(int idUser)
      : this()
    {
      this.IdUser = idUser;
    }
    public CDatabase()
    {
      db = new alextradeEntities();
      IdUser = -1;
    }
    public string sErr;
    private string GetInnerException(Exception ex)
    {
      if (ex.InnerException != null)
      {
        return string.Format("{0} > {1} ", ex.InnerException.Message, GetInnerException(ex.InnerException));
      }
      if (ex.Source == "EntityFramework")
        if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() > 0)
        {
          return "EntityFramework -> " + ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
        }
      return ex.Message;
    }


    #region MainSetting
    public String GetSettingS(string Name)
    {
      IQueryable<MainSetting> ms = db.MainSetting.Select(n => n).Where(n => n.Name == Name);
      MainSetting[] MainS = ms.ToArray();
      if (ms.Count() == 1)
      {
        return MainS[0].sValue ?? "";
      }
      else
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetSettingS - no able found param " + Name);
      }
      return "";
    }
    public int GetSettingI(string Name)
    {
      IQueryable<MainSetting> ms = db.MainSetting.Select(n => n).Where(n => n.Name == Name);
      MainSetting[] MainS = ms.ToArray();
      if (ms.Count() == 1)
      {
        return MainS[0].iValue ?? 0;
      }
      else
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetSettingI - no able found param " + Name);
      }
      return 0;
    }
    public DateTime GetSettingD(string Name)
    {
      IQueryable<MainSetting> ms = db.MainSetting.Select(n => n).Where(n => n.Name == Name);
      MainSetting[] MainS = ms.ToArray();
      if (ms.Count() == 1)
      {
        DateTime dt = MainS[0].dValue ?? DateTime.MinValue;
        //        DateTime.TryParse(MainS[0].SValue, out dt);
        if (DateTime.MinValue == dt)
        {
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetSettingD - no able found param " + Name);
        }
        return dt;
      }
      else
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetSettingD - no able found param " + Name);

      }
      return DateTime.MinValue;
    }
    public bool GetSettingB(string Name)
    {
      IQueryable<MainSetting> ms = db.MainSetting.Select(n => n).Where(n => n.Name == Name);
      MainSetting[] MainS = ms.ToArray();
      if (ms.Count() == 1)
      {
        return MainS[0].iValue == 0 ? false : true;
      }
      else
      {
        CMainEventLog EL = new CMainEventLog();
        EL.WriteMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetSettingB - no able found param " + Name);

      }
      return false;
    }

    public bool SetSetting(string Name, string sValue)
    {
      try
      {
        {
          var stud = (from s in db.MainSetting
                      where s.Name == Name
                      select s).FirstOrDefault();
          stud.sValue = sValue;
          int num = db.SaveChanges();
        }
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "SetSetting String - no able write param " + Name + ", Value = " + sValue + ".  " + GetInnerException(Ex));
        return false;
      }
      return true;
    }
    public bool SetSetting(string Name, int iValue)
    {
      try
      {
        {
          var stud = (from s in db.MainSetting
                      where s.Name == Name
                      select s).FirstOrDefault();
          stud.iValue = iValue;
          int num = db.SaveChanges();
        }
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "SetSetting Int - no able write param " + Name + ", Value = " + iValue + ".  " + GetInnerException(Ex));
        return false;
      }
      return true;
    }
    public bool SetSetting(string Name, DateTime dValue)
    {
      try
      {
        {
          var stud = (from s in db.MainSetting
                      where s.Name == Name
                      select s).FirstOrDefault();
          stud.dValue = dValue;
          int num = db.SaveChanges();
        }
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "SetSetting DateTime - no able write param " + Name + ", Value = " + dValue + ".   " + GetInnerException(Ex));
        return false;
      }
      return true;
    }
    public bool SetSetting(string Name, bool bValue)
    {
      try
      {
        {
          var stud = (from s in db.MainSetting
                      where s.Name == Name
                      select s).FirstOrDefault();
          stud.iValue = bValue ? 1 : 0;
          int num = db.SaveChanges();
        }
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "SetSetting DateTime - no able write param " + Name + ", Value = " + bValue.ToString() + ".   " + GetInnerException(Ex));
        return false;
      }
      return true;
    }

    #endregion


    public Users GetUser(string LoginName)
    {
      try
      {
        var exp = from U in db.Users
                  where U.LoginName == LoginName
                  select U;
        if (exp.Count() > 0)
          return exp.FirstOrDefault();
        else
          return null;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetUser()" + GetInnerException(Ex));
      }
      return null;
    }

  }
}
