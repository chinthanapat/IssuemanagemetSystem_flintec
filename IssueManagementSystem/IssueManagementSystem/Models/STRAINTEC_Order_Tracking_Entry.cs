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
    
    public partial class STRAINTEC_Order_Tracking_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Supplied_by { get; set; }
        public string Demanded_by { get; set; }
        public System.DateTime Shipment_Date { get; set; }
        public System.DateTime Expected_Receipt_Date { get; set; }
        public string Item_No_ { get; set; }
        public decimal Quantity { get; set; }
        public int Level { get; set; }
        public int For_Type { get; set; }
        public int For_Subtype { get; set; }
        public string For_ID { get; set; }
        public string For_Batch_Name { get; set; }
        public int For_Prod__Order_Line { get; set; }
        public int For_Ref__No_ { get; set; }
        public int From_Type { get; set; }
        public int From_Subtype { get; set; }
        public string From_ID { get; set; }
        public string From_Batch_Name { get; set; }
        public int From_Prod__Order_Line { get; set; }
        public int From_Ref__No_ { get; set; }
        public System.DateTime Starting_Date { get; set; }
        public System.DateTime Ending_Date { get; set; }
        public string Name { get; set; }
        public byte Warning { get; set; }
    }
}
