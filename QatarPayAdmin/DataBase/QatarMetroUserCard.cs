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
    
    public partial class QatarMetroUserCard
    {
        public int ID { get; set; }
        public string CardNumber { get; set; }
        public int CardTypeID { get; set; }
        public bool IsActive { get; set; }
        public int UserID { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModiiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
    }
}
