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
    
    public partial class wItems
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
        public string UnitShort { get; set; }
        public string UnitFull { get; set; }
        public Nullable<int> idFirm { get; set; }
        public string Ic { get; set; }
        public string Dic { get; set; }
        public string FirmName { get; set; }
        public Nullable<double> BasePriceBezDPH { get; set; }
        public Nullable<double> PriceBezDPH { get; set; }
        public Nullable<int> idSazbaDPH { get; set; }
    }
}
