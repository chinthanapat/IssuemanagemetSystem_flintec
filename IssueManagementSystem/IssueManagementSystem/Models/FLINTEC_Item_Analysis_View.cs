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
    
    public partial class FLINTEC_Item_Analysis_View
    {
        public byte[] timestamp { get; set; }
        public int Analysis_Area { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Last_Entry_No_ { get; set; }
        public int Last_Budget_Entry_No_ { get; set; }
        public System.DateTime Last_Date_Updated { get; set; }
        public byte Update_on_Posting { get; set; }
        public byte Blocked { get; set; }
        public string Item_Filter { get; set; }
        public string Location_Filter { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public int Date_Compression { get; set; }
        public string Dimension_1_Code { get; set; }
        public string Dimension_2_Code { get; set; }
        public string Dimension_3_Code { get; set; }
        public byte Include_Budgets { get; set; }
        public byte Refresh_When_Unblocked { get; set; }
    }
}
