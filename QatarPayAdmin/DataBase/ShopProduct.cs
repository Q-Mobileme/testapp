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
    
    public partial class ShopProduct
    {
        public int ID { get; set; }
        public int ShopID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductNameAr { get; set; }
        public string ProductDescriptionAr { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageLocation { get; set; }
        public string ProductImageThumbnail { get; set; }
        public bool IsActive { get; set; }
        public int UserID { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
