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
    
    public partial class STRAINTEC_RMA
    {
        public byte[] timestamp { get; set; }
        public string RMA_No_ { get; set; }
        public System.DateTime Date_Received { get; set; }
        public string Customer_Name { get; set; }
        public string End_Customer_Name { get; set; }
        public string Coordinator { get; set; }
        public decimal Qty { get; set; }
        public decimal Loadcells { get; set; }
        public decimal Electronic_Item { get; set; }
        public string Repair___Replacement__Credit { get; set; }
        public decimal Fintec_Responsible_Issues { get; set; }
        public string Authorization { get; set; }
        public string Communication { get; set; }
        public string Cause___Correc__Action_Report { get; set; }
        public decimal Report_Submit_Date { get; set; }
        public string Electronic_Item_Stats { get; set; }
        public System.DateTime Repair_OK_Given_Date { get; set; }
        public System.DateTime Sent_To_Dispatch_On { get; set; }
        public int RMA_Open_Close { get; set; }
        public System.DateTime Shipped_Date { get; set; }
        public decimal Avg__Turn_Over_On_Disp___Days_ { get; set; }
        public decimal Avg__Turn_Over_On_Ship___Days_ { get; set; }
        public string Comment { get; set; }
        public decimal Accessories { get; set; }
        public string Load_Cell_Numbers { get; set; }
    }
}
