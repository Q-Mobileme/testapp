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
    
    public partial class PaymentRequest
    {
        public int ID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string RequestNo { get; set; }
        public int UserID { get; set; }
        public int TransactionReferenceID { get; set; }
        public string TransactionReferenceNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobileNo { get; set; }
        public string Country { get; set; }
        public int StatusID { get; set; }
        public bool IsCompleted { get; set; }
        public System.DateTime CompletedDate { get; set; }
        public string IPAddress { get; set; }
        public decimal Amount { get; set; }
        public string PlatForm { get; set; }
        public string DeviceToken { get; set; }
        public int ServiceID { get; set; }
        public string PaymentDescription { get; set; }
    }
}