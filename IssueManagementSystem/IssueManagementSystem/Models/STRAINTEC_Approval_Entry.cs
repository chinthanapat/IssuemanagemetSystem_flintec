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
    
    public partial class STRAINTEC_Approval_Entry
    {
        public byte[] timestamp { get; set; }
        public int Table_ID { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public int Sequence_No_ { get; set; }
        public string Approval_Code { get; set; }
        public string Sender_ID { get; set; }
        public string Salespers__Purch__Code { get; set; }
        public string Approver_ID { get; set; }
        public int Status { get; set; }
        public System.DateTime Date_Time_Sent_for_Approval { get; set; }
        public System.DateTime Last_Date_Time_Modified { get; set; }
        public string Last_Modified_By_ID { get; set; }
        public System.DateTime Due_Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Amount__LCY_ { get; set; }
        public string Currency_Code { get; set; }
        public int Approval_Type { get; set; }
        public int Limit_Type { get; set; }
        public decimal Available_Credit_Limit__LCY_ { get; set; }
    }
}
