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
    
    public partial class STRAINTEC_Warehouse_Journal_Template
    {
        public byte[] timestamp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Test_Report_ID { get; set; }
        public int Page_ID { get; set; }
        public int Registering_Report_ID { get; set; }
        public byte Force_Registering_Report { get; set; }
        public int Type { get; set; }
        public string Source_Code { get; set; }
        public string Reason_Code { get; set; }
        public string No__Series { get; set; }
        public string Registering_No__Series { get; set; }
    }
}
