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
    
    public partial class Service
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameArabic { get; set; }
        public string Description { get; set; }
        public string DescriptionArabic { get; set; }
        public string ThumbnailLocation { get; set; }
        public string ImageLocation { get; set; }
        public bool IsActive { get; set; }
        public bool ShowInApp { get; set; }
        public int UserID { get; set; }
        public System.DateTime EntryTime { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
    }
}