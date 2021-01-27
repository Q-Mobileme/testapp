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
    
    public partial class Transaction
    {
        public int ID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int TransactionTypeID { get; set; }
        public int TransactionStatusID { get; set; }
        public int UserID { get; set; }
        public decimal Amount { get; set; }
        public int CurrencyID { get; set; }
        public string IpAddress { get; set; }
        public string TransactionID { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModifiedBy { get; set; }
        public int ApprovedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public string TransactionDescription { get; set; }
        public decimal LocalAmount { get; set; }
        public int LocalCurrencyID { get; set; }
        public int RequestID { get; set; }
        public string SecureHash { get; set; }
        public string EncryptedData { get; set; }
        public string Description { get; set; }
        public Nullable<int> DestinationUserID { get; set; }
        public Nullable<int> TransactionDesc { get; set; }
    }
}
