//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QatarPayAdmin.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TopUpRequest
    {
        public int ID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public int UserID { get; set; }
        public string MSISDN { get; set; }
        public string ProductNumber { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductSellingPrice { get; set; }
        public decimal MarkUp { get; set; }
        public string ReferenceNumber { get; set; }
        public string ReserveID { get; set; }
        public string ReserveIDNumber { get; set; }
        public bool IsComsumed { get; set; }
        public bool TransactionStatus { get; set; }
        public string InvoiceNumber { get; set; }
        public string SupplierReference { get; set; }
        public string TransactionDescription { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
    }
}