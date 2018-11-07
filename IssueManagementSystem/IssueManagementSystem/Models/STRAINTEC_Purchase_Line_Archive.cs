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
    
    public partial class STRAINTEC_Purchase_Line_Archive
    {
        public byte[] timestamp { get; set; }
        public int Document_Type { get; set; }
        public string Document_No_ { get; set; }
        public int Doc__No__Occurrence { get; set; }
        public int Version_No_ { get; set; }
        public int Line_No_ { get; set; }
        public string Buy_from_Vendor_No_ { get; set; }
        public int Type { get; set; }
        public string No_ { get; set; }
        public string Location_Code { get; set; }
        public string Posting_Group { get; set; }
        public System.DateTime Expected_Receipt_Date { get; set; }
        public string Description { get; set; }
        public string Description_2 { get; set; }
        public string Unit_of_Measure { get; set; }
        public decimal Quantity { get; set; }
        public decimal Outstanding_Quantity { get; set; }
        public decimal Qty__to_Invoice { get; set; }
        public decimal Qty__to_Receive { get; set; }
        public decimal Direct_Unit_Cost { get; set; }
        public decimal Unit_Cost__LCY_ { get; set; }
        public decimal VAT__ { get; set; }
        public decimal Quantity_Disc___ { get; set; }
        public decimal Line_Discount__ { get; set; }
        public decimal Line_Discount_Amount { get; set; }
        public decimal Amount { get; set; }
        public decimal Amount_Including_VAT { get; set; }
        public decimal Unit_Price__LCY_ { get; set; }
        public byte Allow_Invoice_Disc_ { get; set; }
        public decimal Gross_Weight { get; set; }
        public decimal Net_Weight { get; set; }
        public decimal Units_per_Parcel { get; set; }
        public decimal Unit_Volume { get; set; }
        public int Appl__to_Item_Entry { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public string Job_No_ { get; set; }
        public decimal Indirect_Cost__ { get; set; }
        public decimal Outstanding_Amount { get; set; }
        public decimal Qty__Rcd__Not_Invoiced { get; set; }
        public decimal Amt__Rcd__Not_Invoiced { get; set; }
        public decimal Quantity_Received { get; set; }
        public decimal Quantity_Invoiced { get; set; }
        public string Receipt_No_ { get; set; }
        public int Receipt_Line_No_ { get; set; }
        public decimal Profit__ { get; set; }
        public string Pay_to_Vendor_No_ { get; set; }
        public decimal Inv__Discount_Amount { get; set; }
        public string Vendor_Item_No_ { get; set; }
        public string Sales_Order_No_ { get; set; }
        public int Sales_Order_Line_No_ { get; set; }
        public byte Drop_Shipment { get; set; }
        public string Gen__Bus__Posting_Group { get; set; }
        public string Gen__Prod__Posting_Group { get; set; }
        public int VAT_Calculation_Type { get; set; }
        public string Transaction_Type { get; set; }
        public string Transport_Method { get; set; }
        public int Attached_to_Line_No_ { get; set; }
        public string Entry_Point { get; set; }
        public string Area { get; set; }
        public string Transaction_Specification { get; set; }
        public string Tax_Area_Code { get; set; }
        public byte Tax_Liable { get; set; }
        public string Tax_Group_Code { get; set; }
        public byte Use_Tax { get; set; }
        public string VAT_Bus__Posting_Group { get; set; }
        public string VAT_Prod__Posting_Group { get; set; }
        public string Currency_Code { get; set; }
        public decimal Outstanding_Amount__LCY_ { get; set; }
        public decimal Amt__Rcd__Not_Invoiced__LCY_ { get; set; }
        public string Blanket_Order_No_ { get; set; }
        public int Blanket_Order_Line_No_ { get; set; }
        public decimal VAT_Base_Amount { get; set; }
        public decimal Unit_Cost { get; set; }
        public byte System_Created_Entry { get; set; }
        public decimal Line_Amount { get; set; }
        public decimal VAT_Difference { get; set; }
        public decimal Inv__Disc__Amount_to_Invoice { get; set; }
        public string VAT_Identifier { get; set; }
        public int IC_Partner_Ref__Type { get; set; }
        public string IC_Partner_Reference { get; set; }
        public decimal Prepayment__ { get; set; }
        public decimal Prepmt__Line_Amount { get; set; }
        public decimal Prepmt__Amt__Inv_ { get; set; }
        public decimal Prepmt__Amt__Incl__VAT { get; set; }
        public decimal Prepayment_Amount { get; set; }
        public decimal Prepmt__VAT_Base_Amt_ { get; set; }
        public decimal Prepayment_VAT__ { get; set; }
        public int Prepmt__VAT_Calc__Type { get; set; }
        public string Prepayment_VAT_Identifier { get; set; }
        public string Prepayment_Tax_Area_Code { get; set; }
        public byte Prepayment_Tax_Liable { get; set; }
        public string Prepayment_Tax_Group_Code { get; set; }
        public decimal Prepmt_Amt_to_Deduct { get; set; }
        public decimal Prepmt_Amt_Deducted { get; set; }
        public byte Prepayment_Line { get; set; }
        public decimal Prepmt__Amount_Inv__Incl__VAT { get; set; }
        public string IC_Partner_Code { get; set; }
        public int Dimension_Set_ID { get; set; }
        public string Prod__Order_No_ { get; set; }
        public string Variant_Code { get; set; }
        public string Bin_Code { get; set; }
        public decimal Qty__per_Unit_of_Measure { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public decimal Quantity__Base_ { get; set; }
        public decimal Outstanding_Qty___Base_ { get; set; }
        public decimal Qty__to_Invoice__Base_ { get; set; }
        public decimal Qty__to_Receive__Base_ { get; set; }
        public decimal Qty__Rcd__Not_Invoiced__Base_ { get; set; }
        public decimal Qty__Received__Base_ { get; set; }
        public decimal Qty__Invoiced__Base_ { get; set; }
        public System.DateTime FA_Posting_Date { get; set; }
        public int FA_Posting_Type { get; set; }
        public string Depreciation_Book_Code { get; set; }
        public decimal Salvage_Value { get; set; }
        public byte Depr__until_FA_Posting_Date { get; set; }
        public byte Depr__Acquisition_Cost { get; set; }
        public string Maintenance_Code { get; set; }
        public string Insurance_No_ { get; set; }
        public string Budgeted_FA_No_ { get; set; }
        public string Duplicate_in_Depreciation_Book { get; set; }
        public byte Use_Duplication_List { get; set; }
        public string Responsibility_Center { get; set; }
        public string Cross_Reference_No_ { get; set; }
        public string Unit_of_Measure__Cross_Ref__ { get; set; }
        public int Cross_Reference_Type { get; set; }
        public string Cross_Reference_Type_No_ { get; set; }
        public string Item_Category_Code { get; set; }
        public byte Nonstock { get; set; }
        public string Purchasing_Code { get; set; }
        public string Product_Group_Code { get; set; }
        public byte Special_Order { get; set; }
        public string Special_Order_Sales_No_ { get; set; }
        public int Special_Order_Sales_Line_No_ { get; set; }
        public byte Completely_Received { get; set; }
        public System.DateTime Requested_Receipt_Date { get; set; }
        public System.DateTime Promised_Receipt_Date { get; set; }
        public string Lead_Time_Calculation { get; set; }
        public string Inbound_Whse__Handling_Time { get; set; }
        public System.DateTime Planned_Receipt_Date { get; set; }
        public System.DateTime Order_Date { get; set; }
        public byte Allow_Item_Charge_Assignment { get; set; }
        public decimal Return_Qty__to_Ship { get; set; }
        public decimal Return_Qty__to_Ship__Base_ { get; set; }
        public decimal Return_Qty__Shipped_Not_Invd_ { get; set; }
        public decimal Ret__Qty__Shpd_Not_Invd__Base_ { get; set; }
        public decimal Return_Shpd__Not_Invd_ { get; set; }
        public decimal Return_Shpd__Not_Invd___LCY_ { get; set; }
        public decimal Return_Qty__Shipped { get; set; }
        public decimal Return_Qty__Shipped__Base_ { get; set; }
        public string Return_Shipment_No_ { get; set; }
        public int Return_Shipment_Line_No_ { get; set; }
        public string Return_Reason_Code { get; set; }
        public string Routing_No_ { get; set; }
        public string Operation_No_ { get; set; }
        public string Work_Center_No_ { get; set; }
        public byte Finished { get; set; }
        public int Prod__Order_Line_No_ { get; set; }
        public decimal Overhead_Rate { get; set; }
        public byte MPS_Order { get; set; }
        public int Planning_Flexibility { get; set; }
        public string Safety_Lead_Time { get; set; }
        public int Routing_Reference_No_ { get; set; }
    }
}
