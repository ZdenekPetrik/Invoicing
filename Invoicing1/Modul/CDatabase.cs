using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoicing.Modul;
using System.Linq.Expressions;
using System.Linq.Dynamic;

namespace Invoicing
{
  public class CDatabase
  {
    public string sErr;
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
      IdUser = -1;
      MainState = GetState();
    }
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

    public string MyCN { get { return new alextradeEntities().Database.Connection.ConnectionString; } }
    #region State
    List<State> MainState;

    public enum eOrderState
    {
      /// <summary> New=1: Vytvořena, ale je buď prázdná, nebo ještě nejsou všechny PDF zadány </summary>
      F1_New = 1,
      /// <summary> Caption=2: Všechny PDF jsou zadány - tudíž známe počet Invoice a celkovou sumu + počet položek </summary>
      F2_Caption = 2,
      /// <summary> Items=3: Všechny položky zadány  </summary>
      F3_Items = 3,
      /// <summary> Pair=3: Všechny položky spárovány s porovnávacími údaji  </summary>
      F4_Pair = 4,
      F5_Protocol = 5,
      F5_Close = 6
    }
    public enum eInvoiceState
    {
      /// <summary> Caption=1: Vytvořena hlavička </summary>
      I1_New = 1,
      /// <summary> Caption=2: Všechny PDF jsou zadány - tudíž známe počet Invoice a celkovou sumu + počet položek </summary>
      I2_Items = 2,
      /// <summary> Items=3: Všechny položky zadány  </summary>
      I3_Pair = 3,
    }
    public enum eInvoiceItemState
    {
      /// <summary> Caption=1: Vytvořena hlavička </summary>
      II1_New = 1,
      /// <summary> Caption=2: Všechny PDF jsou zadány - tudíž známe počet Invoice a celkovou sumu + počet položek </summary>
      II2_Pair = 2,
      /// <summary> Items=3: Všechny položky zadány  </summary>
      II3_Unique = 3,
    }
    public List<State> GetState()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = from S in db.State
                  orderby S.StateType, S.StateValue
                  select S;
        return exp.AsEnumerable().Cast<State>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetState()  " + GetInnerException(Ex));
      }
      return null;
    }

    public string GetOrderDescription(int StateValue)
    {
      return GetStateDescription(1, StateValue);
    }
    public string GetInvoiceDescription(int StateValue)
    {
      return GetStateDescription(2, StateValue);
    }
    public string GetItemDescription(int StateValue)
    {
      return GetStateDescription(3, StateValue);
    }
    public string GetOrderDescription(eOrderState eStateValue)
    {
      return GetOrderDescription((int)eStateValue);
    }

    public string GetStateDescription(int Type, int StateValue)
    {
      var X = MainState.Find(x => x.StateType == 1 && x.StateValue == StateValue);
      if (X == null)
        return "??? ";
      else
      {
        return X.StateValueDescription;
      }
    }

    #endregion

    #region MainSetting
    public String GetSettingS(string Name)
    {
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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
      alextradeEntities db = new alextradeEntities();
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

    #region UserParameter
    public Users GetUser(string LoginName)
    {
      alextradeEntities db = new alextradeEntities();
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
    public string GetUserParameter(string ParamName)
    {
      alextradeEntities db = new alextradeEntities();
      string sResult = "";
      try
      {
        var resultName = from us in db.UserSetting
                         where us.Name.Equals(ParamName) && (us.idUser == IdUser)
                         select us.SValue;

        List<string> sRes = resultName.ToList();
        if (sRes.Count == 1)
          sResult = sRes[0];
        else if (sRes.Count > 1)
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetUserParameter(" + ParamName + ") - No One Parameter ");
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetUserParameter(" + ParamName + ") - " + GetInnerException(Ex));
      }
      return sResult;
    }

    public string SetUserParameter(string ParamName, string ParamValue)
    {
      alextradeEntities db = new alextradeEntities();
      string sResult = "";
      try
      {
        var resultName = from us in db.UserSetting
                         where us.Name.Equals(ParamName) && (us.idUser == IdUser)
                         select us;

        List<UserSetting> sRes = resultName.ToList();
        if (sRes.Count == 1)
          sRes[0].SValue = ParamValue;
        else if (sRes.Count == 0)
        {
          UserSetting us = new UserSetting();
          us.idUser = IdUser; us.Name = ParamName; us.SValue = ParamValue;
          db.UserSetting.Add(us);
        }
        else if (sRes.Count > 1)
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetUserParameter(" + ParamName + ") - No One Parameter ");
        db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetUserParameter(" + ParamName + ") - " + GetInnerException(Ex));
      }
      return sResult;

    }

    #endregion

    public List<wOrders> GetOrders()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from O in db.wOrders
                   select O);
        return exp.AsEnumerable().Cast<wOrders>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetOrders()  " + GetInnerException(Ex));
      }
      return null;
    }
    public wOrders GetOrder(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from O in db.wOrders
                   where O.idOrder == idOrder
                   select O);
        return exp.FirstOrDefault();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetOrder(" + idOrder + ")  " + GetInnerException(Ex));
      }
      return null;
    }
    public bool NewOrder(int idFirm, string Name, DateTime OrderDate, string ScanPath, string ScanPrefix, int NrScan)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        Orders O = new Orders();
        O.CreateDate = DateTime.Now;
        O.idFirm = idFirm;
        O.Name = Name;
        O.NrSCAN = NrScan;
        O.SCANPath = ScanPath;
        O.SCANPrefix = ScanPrefix;
        O.OrderDate = OrderDate;
        O.idUser = IdUser;
        db.Orders.Add(O);
        int num = db.SaveChanges();
        OrderState OrdState = new OrderState();
        OrdState.idOrder = O.idOrder;
        OrdState.CreateDate = DateTime.Now;
        OrdState.ApplicationName = ApplicationName;
        OrdState.idUser = IdUser;
        OrdState.StateValue = (int)eOrderState.F1_New;
        db.OrderState.Add(OrdState);
        num = db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "NewFirm() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return false;
      }
      return true;

    }

    public List<wFirms> GetFirms()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from F in db.wFirms
                   orderby F.Name
                   select F);
        return exp.AsEnumerable().Cast<wFirms>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetFirms()  " + GetInnerException(Ex));
      }
      return null;
    }
    public List<wFirms> GetFirms(string Ico, string Name)
    {
      alextradeEntities db = new alextradeEntities();
      List<wFirms> myResult = new List<wFirms>();
      try
      {
        var tmpResult = db.wFirms.AsQueryable();
        if (Ico != null && Ico.Length > 0)
        {
          tmpResult = tmpResult.Where(r => r.Ic.CompareTo (Ico) == 0);
        }
        if (Name != null &&  Name.Length > 0)
          tmpResult = tmpResult.Where(r => r.Name.CompareTo (Name) == 0);
        myResult = tmpResult.ToList();
        return myResult;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetFirms()  " + GetInnerException(Ex));
      }
      return null;
    }
    public int NewFirm(string Name, string Ic, string Dic, string Adress, string ZipCode, string City)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        Firms F = new Firms();
        F.Name = Name;
        F.Ic = Ic;
        F.Dic = Dic;
        F.Ic = Ic;
        F.Adress = Adress;
        F.ZipCode = ZipCode;
        F.City = City;
        db.Firms.Add(F);
        int num = db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "NewFirm() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return -1;
      }
      return 1;

    }
    public wFirms GetFirm(int idFirm)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from F in db.wFirms
                   where idFirm == F.idFirm
                   orderby F.Name
                   select F);
        return exp.FirstOrDefault();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetFirm()  " + GetInnerException(Ex));
      }
      return null;
    }

    public List<FirmCategory> GetFirmCategory()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from FC in db.FirmCategory
                   orderby FC.idFirmCategory
                   select FC);
        return exp.AsEnumerable().Cast<FirmCategory>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetFirmCategory()  " + GetInnerException(Ex));
      }
      return null;
    }

    public int FirmUpdate(wFirms Firm)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        var exp = (from F in db.Firms
                   where F.idFirm == Firm.idFirm
                   select F);
        Firms FNew = exp.FirstOrDefault();
        if (FNew == null || FNew.idFirm != Firm.idFirm)
        {
          sErr = "FirmUpdate(" + Firm.idFirm.ToString() + ") - no able delete, because does not exist ";
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Warning, sErr);
          return -1;
        }
        FNew.idFirm = Firm.idFirm;
        FNew.Adress = Firm.Adress;
        FNew.City = Firm.City;
        FNew.Dic = Firm.Dic;
        FNew.idFirmCategory = Firm.idFirmCategory;
        FNew.Name = Firm.Name;
        FNew.ZipCode = Firm.ZipCode;
        return db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "FirmUpdate()  " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return -1;
      }
      return 0;

    }


    public List<wFirms> GetSupplierInOrder(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from F in db.wFirms
                   join I in db.Invoices on F.idFirm equals I.idFirm
                   where I.idOrder == idOrder
                   orderby F.Name
                   select F);
        return exp.Distinct().AsEnumerable().Cast<wFirms>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetSupplierInOrder()  " + GetInnerException(Ex));
      }
      return null;
    }


    public int NewInvoice(int MyNumber, string HisNumber, int NrItems, double dPrice, DateTime dateDUZP, int idFirm, int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        Invoices I = new Invoices();
        I.idFirm = idFirm;
        I.idOrder = idOrder;
        I.idUser = IdUser;
        I.MyNumber = MyNumber;
        I.HisNumber = HisNumber;
        I.NrItems = NrItems;
        I.DateDUZP = dateDUZP;
        I.Price = dPrice;
        I.InsertDate = DateTime.Now;
        db.Invoices.Add(I);
        int num = db.SaveChanges();
        InvoiceState InvState = new InvoiceState();
        InvState.idInvoice = I.idInvoice;
        InvState.CreateDate = DateTime.Now;
        InvState.ApplicationName = ApplicationName;
        InvState.idUser = IdUser;
        InvState.StateValue = (int)eInvoiceState.I1_New;
        db.InvoiceState.Add(InvState);
        num = db.SaveChanges();

        return I.idInvoice;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "NewInvoice() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return -1;
      }
    }

    public int InvoiceStateNew(int idInvoice, int NewState)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        InvoiceState InvState = new InvoiceState();
        InvState.idInvoice = idInvoice;
        InvState.CreateDate = DateTime.Now;
        InvState.ApplicationName = ApplicationName;
        InvState.idUser = IdUser;
        InvState.StateValue = NewState;
        db.InvoiceState.Add(InvState);
        db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "InvoiceStateNew() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return -1;
      }
      return 1;

  }


    public ScanPDFs GetScanPDF(int idScan)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from S in db.ScanPDFs
                   where S.idScan == idScan
                   select S);
        return exp.FirstOrDefault();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetScanPDF()  " + GetInnerException(Ex));
      }
      return null;
    }

    public List<ScanPDFs> GetScanPDFs(int idOrder, int idInvoice, int ScanIncrement)
    {
      alextradeEntities db = new alextradeEntities();
      List<ScanPDFs> myResult = new List<ScanPDFs>();
      try
      {
        var tmpResult = db.ScanPDFs.AsQueryable();
        if (idOrder != -1)
          tmpResult = tmpResult.Where(r => r.idOrder == idOrder);
        if (idInvoice != -1)
          tmpResult = tmpResult.Where(r => r.idInvoice == idInvoice);
        if (ScanIncrement != -1)
          tmpResult = tmpResult.Where(r => r.ScanIncrement == ScanIncrement);
        myResult = tmpResult.ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetScanPDFs()  " + GetInnerException(Ex));
      }
      return myResult;
    }

    public bool NewScanPDFs(int idOrder, int idInvoice, int ScanIncrement)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        ScanPDFs PDF = new ScanPDFs();
        PDF.idInvoice = idInvoice;
        PDF.idOrder = idOrder;
        PDF.ScanIncrement = ScanIncrement;
        db.ScanPDFs.Add(PDF);
        int num = db.SaveChanges();
        return true;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "NewInvoice() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return false;
      }

    }

    public wScanPDFs GetwScanPDF(int idScan)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from S in db.wScanPDFs
                   where S.idScan == idScan
                   select S);
        return exp.FirstOrDefault();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetwScanPDF()  " + GetInnerException(Ex));
      }
      return null;
    }
    public List<wScanPDFs> GetwScanPDFOrderList(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from S in db.wScanPDFs
                   where S.idOrder == idOrder
                   orderby S.idScan
                   select S);
        return exp.AsEnumerable().Cast<wScanPDFs>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetwScanPDFOrderList()  " + GetInnerException(Ex));
      }
      return null;
    }

    public List<Invoices> GetInvoices(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from I in db.Invoices
                   where I.idOrder == idOrder
                   orderby I.MyNumber
                   select I);
        return exp.AsEnumerable().Cast<Invoices>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetInvoices()  " + GetInnerException(Ex));
      }
      return null;

    }

    public wInvoices GetInvoice(int idInvoice)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from I in db.wInvoices
                   where I.idInvoice == idInvoice
                   orderby I.MyNumber
                   select I).FirstOrDefault();
        return exp;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetInvoice()  " + GetInnerException(Ex));
      }
      return null;

    }
    public List<wInvoices> GetwInvoices(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from I in db.wInvoices
                   where I.idOrder == idOrder
                   orderby I.MyNumber
                   select I);
        return exp.AsEnumerable().Cast<wInvoices>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetwInvoices()  " + GetInnerException(Ex));
      }
      return null;

    }

    public bool InvoiceDelete(int idInvoice)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        var exp = (from I in db.Invoices
                   where I.idInvoice == idInvoice
                   select I);
        Invoices Inv = exp.FirstOrDefault();
        if (Inv == null || Inv.idInvoice != idInvoice)
        {
          sErr = "DeleteInvoice(" + idInvoice.ToString() + ") - no able delete, because does not exist ";
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Warning, sErr);
          return false;
        }
        db.Invoices.Remove(Inv);

        db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "DeleteInvoice()  " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return false;
      }
      return true;


    }
    public int InvoiceUpdate(wInvoices Inv)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        var exp = (from I in db.Invoices
                   where I.idInvoice == Inv.idInvoice
                   select I);
        Invoices InvNew = exp.FirstOrDefault();
        if (InvNew == null || InvNew.idInvoice != Inv.idInvoice)
        {
          sErr = "InvoiceUpdate(" + Inv.idInvoice.ToString() + ") - no able delete, because does not exist ";
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Warning, sErr);
          return -1;
        }
        InvNew.DateDUZP = Inv.DateDUZP;
        InvNew.HisNumber = Inv.HisNumber;
        InvNew.idFirm = Inv.idFirm;
        InvNew.MyNumber = Inv.MyNumber;
        InvNew.NrItems = Inv.NrItems;
        InvNew.Price = Inv.Price;
        return db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "InvoiceUpdate()  " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return -1;
      }
      return 0;

    }


    public List<Unity> GetUnities()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from U in db.Unity
                   orderby U.idUnit
                   select U);
        return exp.AsEnumerable().Cast<Unity>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetUnities()  " + GetInnerException(Ex));
      }
      return null;

    }


    public  List<SazbaDPH> GetDPH()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from DPH in db.SazbaDPH
                   orderby DPH.idSazbaDPH
                   select DPH);
        return exp.AsEnumerable().Cast<SazbaDPH>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetDPH()  " + GetInnerException(Ex));
      }
      return null;
    }

    #region ITEMS
    public List<wItems> GetItemsForInvoice(int idInvoice)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from II in db.wItems
                   where II.idInvoice == idInvoice
                   orderby II.idInvoiceItem
                   select II);
          return exp.AsEnumerable().Cast<wItems>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetItemsForInvoice()  " + GetInnerException(Ex));
      }
      return null;

    }
    public List<wItems> GetItemsForFirm(int idOrder,int idFirm)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from I in db.Invoices
                   join II in db.wItems on I.idInvoice equals II.idInvoice
                   where I.idOrder == idOrder && I.idFirm == idFirm
                   orderby II.idInvoiceItem
                   select II);
          return exp.AsEnumerable().Cast<wItems>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetItemsForFirm()  " + GetInnerException(Ex));
      }
      return null;

    }
    public List<wItems> GetItemsForPDF(int idScan)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from S in db.wScanPDFs
                   join II in db.wItems on S.idInvoice equals II.idInvoice
                   where S.idScan == idScan   && S.ScanIncrement == II.ScanIncrement
                   select II);
          return exp.AsEnumerable().Cast<wItems>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetItemsForFirm()  " + GetInnerException(Ex));
      }
      return null;

    }

    internal List<wItems> GetItemsForOrder(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from I in db.Invoices
                   join II in db.wItems on I.idInvoice equals II.idInvoice
                   where I.idOrder == idOrder
                   select II);
        return exp.AsEnumerable().Cast<wItems>().ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetItemsForFirm()  " + GetInnerException(Ex));
      }
      return null;
    }

    // Ještě chybí kaskádové mazání v DB
    public bool InvoiceItemDelete(int idInvoiceItem)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        var exp = (from II in db.InvoiceItems
                   where II.idInvoiceItem == idInvoiceItem
                   select II);
        InvoiceItems II1 = exp.FirstOrDefault();
        if (II1 == null || II1.idInvoiceItem != idInvoiceItem)
        {
          sErr = "InvoiceItemDelete(" + idInvoiceItem.ToString() + ") - no able delete, because does not exist ";
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Warning, sErr);
          return false;
        }
        db.InvoiceItems.Remove(II1);
        db.SaveChanges();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "InvoiceItemDelete()  " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return false;
      }
      return true;
    }

    public bool InvoiceItemAddOrUpdate(InvoiceItems IIRow, int Mode)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        if (Mode == 1)
        {
          db.InvoiceItems.Add(IIRow);
          int num = db.SaveChanges();
        }
        else
        {
          var exp = (from II in db.InvoiceItems
                     where II.idInvoiceItem == IIRow.idInvoiceItem
                     select II);
          InvoiceItems II1 = exp.FirstOrDefault();
          II1.BasePrice = IIRow.BasePrice;
          II1.idInvoice = IIRow.idInvoice;
          II1.idUnit = IIRow.idUnit;
          II1.InvoiceOrder = IIRow.InvoiceOrder;
          II1.ItemName = IIRow.ItemName;
          II1.Price = IIRow.Price;
          II1.Quantity = IIRow.Quantity;
          II1.ScanIncrement = IIRow.ScanIncrement;
          II1.BasePriceBezDPH = IIRow.BasePriceBezDPH;
          II1.PriceBezDPH = IIRow.PriceBezDPH;
          II1.idSazbaDPH = IIRow.idSazbaDPH;
          db.SaveChanges();
          var x = GetItemsForInvoice(II1.idInvoice??0);
          var exp1 = (from II in db.wItems
                      where II.idInvoiceItem == II1.idInvoiceItem
                     select II).FirstOrDefault();
 //         if (exp1 != null)
 //           db.Entry(exp1).Reload();


          if (II1 == null || II1.idInvoiceItem != IIRow.idInvoiceItem)
          {
            sErr = "InvoiceItemAddOrUpdate(" + IIRow.idInvoiceItem.ToString() + ") - no able Update, because does not exist ";
            db.InvoiceItems.Add(IIRow);
            int num = db.SaveChanges();
            Mode = 1;
          }
          if (Mode == 1)
          {
            InvoiceItemState IIState = new InvoiceItemState();
            IIState.idInvoiceItem = IIRow.idInvoiceItem;
            IIState.CreateDate = DateTime.Now;
            IIState.ApplicationName = ApplicationName;
            IIState.idUser = IdUser;
            IIState.StateValue = (int)eInvoiceItemState.II1_New;
            db.InvoiceItemState.Add(IIState);
            db.SaveChanges();
          }
        }
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "NewInvoice() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return false;
      }
      return true;
    }

    #endregion






    public List<wProductTable> GetProducts()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from P in db.wProductTable
                   orderby P.Product
                   select P);
        return exp.ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetProducts()  " + GetInnerException(Ex));
      }
      return null;
    }

    public List<wProductTable> GetProducts(string[] sName)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      string SearchingString = "";
      int i = 0;
      List<string> sList = new List<string>();
      foreach (string s in sName) {
        string s1 = Helper.OdApostrofuj(s);
        if (s1.Length > 0){
          if (SearchingString.Length > 0)
            SearchingString += " AND ";
          SearchingString += "Product.Contains(@"+(i++).ToString()+")";
          sList.Add(s1);
        }
      }
      List<wProductTable> myResult = new List<wProductTable>();
      try
      {
        var tmpResult = db.wProductTable.AsQueryable();
 /*       if (SearchingString.Length > 0)
        {
          tmpResult = tmpResult.Where(SearchingString);
        }
 */
        if (i == 0) { }
        else if (i == 1)
        {
          tmpResult = tmpResult.Where(SearchingString, sList[0]);
        }
        else if (i == 2)
        {
          tmpResult = tmpResult.Where(SearchingString, sList[0], sList[1]);
        }
        else if (i == 3)
        {
          tmpResult = tmpResult.Where(SearchingString, sList[0], sList[1], sList[2]);
        }
        else if (i == 4)
        {
          tmpResult = tmpResult.Where(SearchingString, sList[0], sList[1], sList[2], sList[2]);
        }
        else {
          sErr = "Maximální počet slov pro hledání = 4";
        }
        myResult = tmpResult.ToList();
        return myResult;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetProducts()  " + GetInnerException(Ex));
      }
      return null;
    }

    internal wProductTable GetProductTable(int IdProduct)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from wPT in db.wProductTable
                   where wPT.idProduct == IdProduct
                   select wPT).FirstOrDefault();
        return exp;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetProductTable(int)  " + GetInnerException(Ex));
      }
      return null;
    }

    public List<wProductTable> GetProductsPlusListing(string sName)
    {
      alextradeEntities db = new alextradeEntities();
      List<wProductTable> myResult = new List<wProductTable>();
      try
      {
        var tmpResult = db.wProductTable.AsQueryable();
        tmpResult = tmpResult.Where("Product.Contains(@0)", sName.Trim());
        tmpResult = tmpResult.OrderBy("Product");
        myResult = tmpResult.ToList();
        return myResult;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetProducts()  " + GetInnerException(Ex));
      }
      return null;
    }




    public List<wPair> GetPairForOrder(int idOrder)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from P in db.wPair
                   where P.idOrder == idOrder
                   orderby P.idInvoiceItem
                   select P);
        return exp.ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetPairForOrder()  " + GetInnerException(Ex));
      }
      return null;
    }

    public List<PairType> GetPairType()
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from P in db.PairType
                   orderby P.idPairType
                   select P);
        return exp.ToList();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetPairType()  " + GetInnerException(Ex));
      }
      return null;
    }

    internal wPair GetPair(int idInvoiceItem)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from P in db.wPair
                   where P.idInvoiceItem == idInvoiceItem
                   select P);
        return exp.ToList().FirstOrDefault();
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "GetPair()  " + GetInnerException(Ex));
      }
      return null;
    }


    public wWeekMinPricesTemp WeekMinPricesTemp(int idProduct)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from PriceMin in db.wWeekMinPricesTemp
                   where PriceMin.idProduct == idProduct
                   select PriceMin).FirstOrDefault();
        return exp;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "WeekMinPricesTemp()  " + GetInnerException(Ex));
      }
      return null;
    }
    public wWeekPricesTemp WeekPricesTemp(int idProduct)
    {
      alextradeEntities db = new alextradeEntities();
      try
      {
        var exp = (from PriceAvg in db.wWeekPricesTemp
                   where PriceAvg.idProduct == idProduct
                   select PriceAvg).FirstOrDefault();
        return exp;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "WeekMinPricesTemp()  " + GetInnerException(Ex));
      }
      return null;
    }

    public bool DeletePair(int idInvoiceItem)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        var exp = (from P in db.Pair
                   where P.idInvoiceItem == idInvoiceItem
                   select P);
        Pair oldPair = exp.FirstOrDefault();
        if (oldPair == null || oldPair.idInvoiceItem != idInvoiceItem)
        {
          sErr = "DeletePair(" + idInvoiceItem.ToString() + ") - no able delete, because does not exist ";
          new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Warning, sErr);
          return false;
        }
        db.Pair.Remove(oldPair);
        db.SaveChanges();
        return true;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "Paruj( " + idInvoiceItem.ToString() + ")  " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
      }
      return false;      
    }


    public bool InsertPair(int idInvoiceItem, int idProduct, int idPairType, double Price, int Week)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        var exp = (from P in db.Pair
                   where  P.idInvoiceItem == idInvoiceItem
                   select P);
        if (exp.Count() > 0)
          DeletePair(idInvoiceItem);
        Pair newPair = new Pair();
        newPair.idInvoiceItem = idInvoiceItem;
        newPair.idProduct = idProduct;
        newPair.idPairType = idPairType;
        newPair.PairPrice = Price;
        newPair.PairWeek = Week;
        newPair.DatePairing = DateTime.Now;
        newPair.idUser = IdUser;
        db.Pair.Add(newPair);
        db.SaveChanges();
        return true;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "Paruj( " + idInvoiceItem.ToString() + ")  " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
      }
      return false;
    }

    public bool AddPrice(int idProduct, int idListedCompany, double Price, DateTime DatePrice, int Week)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        DayPrices P = new DayPrices();
        P.idProduct = idProduct;
        P.idListedCompany = idListedCompany;
        P.Price = Price;
        P.DatePrice = DatePrice;
        P.DayPrice = DatePrice.Day;
        P.WeekPrice = Week;
        P.MonthPrice = DatePrice.Month;
        P.YearPrice = DatePrice.Year;
        db.DayPrices.Add(P);
        int num = db.SaveChanges();
          }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "AddPrice() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return false;
      }
      return true;
    }

    internal int AddProduct(int idKomodita, int idPodkomodita, int idPriznak, string Nazev, double Quantity, int idUnit, string Mark)
    {
      alextradeEntities db = new alextradeEntities();
      sErr = "";
      try
      {
        Product P = new Product();
        P.idKomodita = idKomodita;
        P.idPodkomodita = idPodkomodita;
        P.idPriznak = idPriznak;
        P.Product1 = Nazev;
        P.Quantity = Quantity;
        P.idUnit = idUnit;
        P.Mark = Mark;
        db.Product.Add(P);
        int num = db.SaveChanges();
        return P.idProduct;
      }
      catch (Exception Ex)
      {
        new CMainEventLog(CMainEventLog.EventCode.e1Message, CMainEventLog.EventSubCode.e2Error, "AddProduct() - no able write. " + GetInnerException(Ex));
        sErr = GetInnerException(Ex);
        return -1;
      }
    }
  }
}
