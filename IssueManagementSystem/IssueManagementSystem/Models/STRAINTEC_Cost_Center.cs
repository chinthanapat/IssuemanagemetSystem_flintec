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
    
    public partial class STRAINTEC_Cost_Center
    {
        public byte[] timestamp { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Cost_Subtype { get; set; }
        public string Responsible_Person { get; set; }
        public string Sorting_Order { get; set; }
        public string Comment { get; set; }
        public int Line_Type { get; set; }
        public byte Blocked { get; set; }
        public byte New_Page { get; set; }
        public byte Blank_Line { get; set; }
        public int Indentation { get; set; }
        public string Totaling { get; set; }
    }
}
