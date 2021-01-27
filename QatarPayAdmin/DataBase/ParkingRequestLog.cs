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
    
    public partial class ParkingRequestLog
    {
        public int ID { get; set; }
        public System.DateTime RequestDate { get; set; }
        public int UserID { get; set; }
        public string IPAddress { get; set; }
        public decimal Price { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal MarkUp { get; set; }
        public System.DateTime CompleteDate { get; set; }
        public string Reference { get; set; }
        public string ClientReference { get; set; }
        public string RawResponse { get; set; }
        public string Description { get; set; }
        public System.DateTime EntryTime { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public int ResellerID { get; set; }
        public int ModifiedBy { get; set; }
        public bool TransactionStatus { get; set; }
        public string TransactionMessage { get; set; }
        public string PlatForm { get; set; }
        public string ParkingTicketNumber { get; set; }
        public string ParkingID { get; set; }
        public System.DateTime TimeIn { get; set; }
        public System.DateTime TimeOut { get; set; }
        public string TotalTime { get; set; }
        public decimal TicketAmount { get; set; }
        public decimal TicketServiceCharge { get; set; }
        public decimal TotalTicketAmount { get; set; }
        public string TicketID { get; set; }
        public string TicketRequestID { get; set; }
        public string TicketPlateNo { get; set; }
        public bool TicketUserHasBalance { get; set; }
        public bool TicketSmsEditorEnable { get; set; }
    }
}
