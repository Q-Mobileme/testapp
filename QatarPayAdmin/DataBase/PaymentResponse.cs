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
    
    public partial class PaymentResponse
    {
        public int ID { get; set; }
        public int PaymentRequestID { get; set; }
        public System.DateTime ResponseDate { get; set; }
        public Nullable<bool> Status { get; set; }
        public string TransactionID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string TransactionStatus { get; set; }
        public string Reference { get; set; }
        public string ServiceName { get; set; }
        public string Mobile { get; set; }
        public string TransactionMessage { get; set; }
        public string PUN { get; set; }
        public string Description { get; set; }
        public string OperatorInvoiceNo { get; set; }
        public Nullable<decimal> DollarAmount { get; set; }
        public string Email { get; set; }
        public string PayeeName { get; set; }
        public Nullable<bool> IsSuccess { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseData { get; set; }
    }
}