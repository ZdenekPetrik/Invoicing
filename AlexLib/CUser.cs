using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexLib
{
  public  class CUser
  {
    public  string LoginName;
    public  string LoginPassword;
    public  string FullName;
    public  bool isLogin;
    public  bool isInvoicing;

    public  bool getUser(string LoginName, string LoginPassword)
    {
      CDatabase DB = new CDatabase();
      Users U = DB.GetUser(LoginName);
      if (U == null)
        return false;
      else {
        LoginName = U.LoginName;
        LoginPassword = U.LoginPassword;
        FullName = U.FullName;
        isLogin = U.isLogin??false;
        isInvoicing = U.isInvoicing??false;
      }

      return true;

    }
  }
}
