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
    
    public partial class UserIDCard
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string IDCardNumber { get; set; }
        public System.DateTime DateofBirth { get; set; }
        public string PlaceofIssue { get; set; }
        public System.DateTime DateofIssue { get; set; }
        public System.DateTime DateofExpiry { get; set; }
        public string ReminderTYpe { get; set; }
        public string FrontSideImageLocation { get; set; }
        public string BackSideImageLocation { get; set; }
        public bool IsActive { get; set; }
        public int UserID { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
    }
}
