using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Modul
{
  class _Default
  {
    public CDatabase DB;
    public CUser LoginUser;
    public wOrders ActiveOrder;

    public _Default()
    {
      DB = Program.DB;
      LoginUser = Program.LoginUser;
      ActiveOrder = Program.ActiveOrder;
    }
  }
}
