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
    
    public partial class STRAINTEC_Fault_Resol__Codes_Rlship_
    {
        public byte[] timestamp { get; set; }
        public string Fault_Code { get; set; }
        public string Fault_Area_Code { get; set; }
        public string Symptom_Code { get; set; }
        public string Resolution_Code { get; set; }
        public string Service_Item_Group_Code { get; set; }
        public int Occurrences { get; set; }
        public string Description { get; set; }
        public byte Created_Manually { get; set; }
    }
}
