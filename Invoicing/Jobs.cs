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
    
    public partial class Jobs
    {
        public int idJob { get; set; }
        public Nullable<System.DateTime> JobDate { get; set; }
        public Nullable<int> idZadavatel { get; set; }
        public string Name { get; set; }
        public string SCANPath { get; set; }
        public Nullable<int> NrSCAN { get; set; }
        public Nullable<int> NrInvoices { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
