//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IssueManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FLINTEC_Contract_Change_Log
    {
        public byte[] timestamp { get; set; }
        public string Contract_No_ { get; set; }
        public int Change_No_ { get; set; }
        public int Contract_Type { get; set; }
        public string User_ID { get; set; }
        public System.DateTime Date_of_Change { get; set; }
        public System.DateTime Time_of_Change { get; set; }
        public int Contract_Part { get; set; }
        public string Field_Description { get; set; }
        public string Old_Value { get; set; }
        public string New_Value { get; set; }
        public int Type_of_Change { get; set; }
        public string Service_Item_No_ { get; set; }
        public int Serv__Contract_Line_No_ { get; set; }
    }
}
