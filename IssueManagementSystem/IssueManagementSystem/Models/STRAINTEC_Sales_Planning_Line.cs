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
    
    public partial class STRAINTEC_Sales_Planning_Line
    {
        public byte[] timestamp { get; set; }
        public string Sales_Order_No_ { get; set; }
        public int Sales_Order_Line_No_ { get; set; }
        public string Item_No_ { get; set; }
        public string Description { get; set; }
        public System.DateTime Shipment_Date { get; set; }
        public decimal Available { get; set; }
        public System.DateTime Next_Planning_Date { get; set; }
        public System.DateTime Expected_Delivery_Date { get; set; }
        public int Planning_Status { get; set; }
        public byte Needs_Replanning { get; set; }
        public string Variant_Code { get; set; }
        public decimal Planned_Quantity { get; set; }
        public int Low_Level_Code { get; set; }
    }
}
