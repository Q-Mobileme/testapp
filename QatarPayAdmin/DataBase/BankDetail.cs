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
    
    public partial class BankDetail
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public Nullable<int> UserID { get; set; }
        public string OwnerName { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string IBAN { get; set; }
        public string SwiftCode { get; set; }
        public int BankNameID { get; set; }
    }
}
