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
    
    public partial class KarwaBusPayment
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public int RequestID { get; set; }
        public bool IsConsumed { get; set; }
        public string IPAddress { get; set; }
        public string RawResponse { get; set; }
        public System.DateTime CompleteDate { get; set; }
        public string TransactionReferenceNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public string CardNumber { get; set; }
        public string VendorReference { get; set; }
        public bool TransactionStatus { get; set; }
        public string PlatForm { get; set; }
        public string TransactionMessage { get; set; }
        public decimal Amount { get; set; }
        public int ServiceID { get; set; }
        public decimal Markup { get; set; }
        public decimal SellingAmount { get; set; }
        public System.DateTime EntryTime { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public int ModifiedBy { get; set; }
    }
}
