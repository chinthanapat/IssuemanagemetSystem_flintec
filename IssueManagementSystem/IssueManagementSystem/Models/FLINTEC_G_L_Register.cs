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
    
    public partial class FLINTEC_G_L_Register
    {
        public byte[] timestamp { get; set; }
        public int No_ { get; set; }
        public int From_Entry_No_ { get; set; }
        public int To_Entry_No_ { get; set; }
        public System.DateTime Creation_Date { get; set; }
        public string Source_Code { get; set; }
        public string User_ID { get; set; }
        public string Journal_Batch_Name { get; set; }
        public int From_VAT_Entry_No_ { get; set; }
        public int To_VAT_Entry_No_ { get; set; }
        public byte Reversed { get; set; }
    }
}
