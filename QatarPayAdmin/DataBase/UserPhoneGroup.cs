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
    
    public partial class UserPhoneGroup
    {
        public int ID { get; set; }
        public string GroupName { get; set; }
        public string GroupNameArabic { get; set; }
        public string GroupCode { get; set; }
        public string GroupDescription { get; set; }
        public string GroupDescriptionArabic { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int UserID { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public int ModifiedBy { get; set; }
    }
}
