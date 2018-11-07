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
    
    public partial class FLINTEC_Service_Item
    {
        public byte[] timestamp { get; set; }
        public string No_ { get; set; }
        public string Serial_No_ { get; set; }
        public string Service_Item_Group_Code { get; set; }
        public string Description { get; set; }
        public string Description_2 { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public string Customer_No_ { get; set; }
        public string Ship_to_Code { get; set; }
        public string Item_No_ { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public string Location_of_Service_Item { get; set; }
        public decimal Sales_Unit_Price { get; set; }
        public decimal Sales_Unit_Cost { get; set; }
        public System.DateTime Warranty_Starting_Date__Labor_ { get; set; }
        public System.DateTime Warranty_Ending_Date__Labor_ { get; set; }
        public System.DateTime Warranty_Starting_Date__Parts_ { get; set; }
        public System.DateTime Warranty_Ending_Date__Parts_ { get; set; }
        public decimal Warranty____Parts_ { get; set; }
        public decimal Warranty____Labor_ { get; set; }
        public decimal Response_Time__Hours_ { get; set; }
        public System.DateTime Installation_Date { get; set; }
        public System.DateTime Sales_Date { get; set; }
        public System.DateTime Last_Service_Date { get; set; }
        public decimal Default_Contract_Value { get; set; }
        public decimal Default_Contract_Discount__ { get; set; }
        public string Vendor_No_ { get; set; }
        public string Vendor_Item_No_ { get; set; }
        public string No__Series { get; set; }
        public string Vendor_Item_Name { get; set; }
        public string Preferred_Resource { get; set; }
        public string Variant_Code { get; set; }
        public string Service_Price_Group_Code { get; set; }
        public decimal Default_Contract_Cost { get; set; }
        public string Search_Description { get; set; }
        public string Sales_Serv__Shpt__Document_No_ { get; set; }
        public int Sales_Serv__Shpt__Line_No_ { get; set; }
        public int Shipment_Type { get; set; }
    }
}
