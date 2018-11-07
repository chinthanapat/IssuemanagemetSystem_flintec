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
    
    public partial class FLINTEC_Value_Entry
    {
        public byte[] timestamp { get; set; }
        public int Entry_No_ { get; set; }
        public string Item_No_ { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public int Item_Ledger_Entry_Type { get; set; }
        public string Source_No_ { get; set; }
        public string Document_No_ { get; set; }
        public string Description { get; set; }
        public string Location_Code { get; set; }
        public string Inventory_Posting_Group { get; set; }
        public string Source_Posting_Group { get; set; }
        public int Item_Ledger_Entry_No_ { get; set; }
        public decimal Valued_Quantity { get; set; }
        public decimal Item_Ledger_Entry_Quantity { get; set; }
        public decimal Invoiced_Quantity { get; set; }
        public decimal Cost_per_Unit { get; set; }
        public decimal Sales_Amount__Actual_ { get; set; }
        public string Salespers__Purch__Code { get; set; }
        public decimal Discount_Amount { get; set; }
        public string User_ID { get; set; }
        public string Source_Code { get; set; }
        public int Applies_to_Entry { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public int Source_Type { get; set; }
        public decimal Cost_Amount__Actual_ { get; set; }
        public decimal Cost_Posted_to_G_L { get; set; }
        public string Reason_Code { get; set; }
        public byte Drop_Shipment { get; set; }
        public string Journal_Batch_Name { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public System.DateTime Document_Date { get; set; }
        public string External_Document_No_ { get; set; }
        public decimal Cost_Amount__Actual___ACY_ { get; set; }
        public decimal Cost_Posted_to_G_L__ACY_ { get; set; }
        public decimal Cost_per_Unit__ACY_ { get; set; }
        public int Document_Type { get; set; }
        public int Document_Line_No_ { get; set; }
        public int Order_Type { get; set; }
        public string Order_No_ { get; set; }
        public int Order_Line_No_ { get; set; }
        public byte Expected_Cost { get; set; }
        public string Item_Charge_No_ { get; set; }
        public byte Valued_By_Average_Cost { get; set; }
        public byte Partial_Revaluation { get; set; }
        public byte Inventoriable { get; set; }
        public System.DateTime Valuation_Date { get; set; }
        public int Entry_Type { get; set; }
        public int Variance_Type { get; set; }
        public decimal Purchase_Amount__Actual_ { get; set; }
        public decimal Purchase_Amount__Expected_ { get; set; }
        public decimal Sales_Amount__Expected_ { get; set; }
        public decimal Cost_Amount__Expected_ { get; set; }
        public decimal Cost_Amount__Non_Invtbl__ { get; set; }
        public decimal Cost_Amount__Expected___ACY_ { get; set; }
        public decimal Cost_Amount__Non_Invtbl___ACY_ { get; set; }
        public decimal Expected_Cost_Posted_to_G_L { get; set; }
        public decimal Exp__Cost_Posted_to_G_L__ACY_ { get; set; }
        public int Dimension_Set_ID { get; set; }
        public string Job_No_ { get; set; }
        public string Job_Task_No_ { get; set; }
        public int Job_Ledger_Entry_No_ { get; set; }
        public string Variant_Code { get; set; }
        public byte Adjustment { get; set; }
        public byte Average_Cost_Exception { get; set; }
        public int Capacity_Ledger_Entry_No_ { get; set; }
        public int Type { get; set; }
        public string No_ { get; set; }
        public string Return_Reason_Code { get; set; }
    }
}
