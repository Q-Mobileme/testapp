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
    
    public partial class KarwaBusRequest
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string VendorReference { get; set; }
        public string RequestNumber { get; set; }
        public string CardNumber { get; set; }
        public string MobileNumber { get; set; }
        public decimal Amount { get; set; }
        public string IPAddress { get; set; }
        public string RawResponse { get; set; }
        public string ResponseReferenceNumber { get; set; }
        public string ResponseMessage { get; set; }
        public bool IsConsumed { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
    }
}
