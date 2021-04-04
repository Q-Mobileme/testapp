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
    
    public partial class DtOneTransactionResponse
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string transaction_type { get; set; }
        public int transaction_id { get; set; }
        public Nullable<bool> simulation { get; set; }
        public string status { get; set; }
        public string status_message { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string account_number { get; set; }
        public string external_id { get; set; }
        public string operator_reference { get; set; }
        public int product_id { get; set; }
        public string product { get; set; }
        public int product_value { get; set; }
        public string product_currency { get; set; }
        public Nullable<int> local_value { get; set; }
        public string local_currency { get; set; }
        public int operator_id { get; set; }
        public string Operator { get; set; }
        public int country_id { get; set; }
        public string country { get; set; }
        public string account_currency { get; set; }
        public Nullable<decimal> wholesale_price { get; set; }
        public Nullable<int> service_id { get; set; }
        public Nullable<decimal> retail_price { get; set; }
        public Nullable<decimal> fee { get; set; }
        public bool sender_sms_notification { get; set; }
        public string sender_sms_text { get; set; }
        public bool recipient_sms_notification { get; set; }
        public string sender_last_name { get; set; }
        public string sender_middle_name { get; set; }
        public string sender_first_name { get; set; }
        public string sender_email { get; set; }
        public string sender_mobile { get; set; }
        public string recipient_last_name { get; set; }
        public string recipient_middle_name { get; set; }
        public string recipient_first_name { get; set; }
        public string recipient_email { get; set; }
        public string recipient_mobile { get; set; }
        public string Reference { get; set; }
        public Nullable<int> TransactionStatusID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string AccessToken { get; set; }
        public string RequestID { get; set; }
        public string producttype { get; set; }
    }
}