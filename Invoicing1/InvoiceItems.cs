//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invoicing
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceItems
    {
        public int idInvoiceItem { get; set; }
        public Nullable<int> idInvoice { get; set; }
        public Nullable<int> InvoiceOrder { get; set; }
        public Nullable<int> ScanIncrement { get; set; }
        public string ItemName { get; set; }
        public Nullable<double> BasePrice { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> idUnit { get; set; }
        public Nullable<int> idSazbaDPH { get; set; }
        public Nullable<double> BasePriceBezDPH { get; set; }
        public Nullable<double> PriceBezDPH { get; set; }
    }
}
