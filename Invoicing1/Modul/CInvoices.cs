using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicing.Modul
{
  class CInvoices : _Default
  {
    public CInvoices()
    {
 
    }

    public List<Invoices> GetInvoices() {
      return DB.GetInvoices(ActiveOrder.idOrder);
    
    }
  }
}
