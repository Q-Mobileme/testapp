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
    
    public partial class NoqsTopupRequest
    {
        public int ID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public int RequestByUserID { get; set; }
        public int StatusID { get; set; }
        public int RequestToUserID { get; set; }
        public string AccessToken { get; set; }
        public string VerificationID { get; set; }
        public int Counter { get; set; }
        public System.DateTime EntryTime { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime CompletedDate { get; set; }
        public string RequestID { get; set; }
        public int CurrencyID { get; set; }
        public string PlatForm { get; set; }
        public decimal Amount { get; set; }
    }
}
