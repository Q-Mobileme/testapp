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
    
    public partial class UserPassport
    {
        public int ID { get; set; }
        public string PasssportNumber { get; set; }
        public string PassportType { get; set; }
        public string PlaceofIssue { get; set; }
        public string SurName { get; set; }
        public string GivenName { get; set; }
        public System.DateTime DateofBirth { get; set; }
        public System.DateTime DateofIssue { get; set; }
        public System.DateTime DateofExpiry { get; set; }
        public string ReminderType { get; set; }
        public string PassportImageLocation { get; set; }
        public bool IsActive { get; set; }
        public int UserID { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime MidifiedTime { get; set; }
    }
}