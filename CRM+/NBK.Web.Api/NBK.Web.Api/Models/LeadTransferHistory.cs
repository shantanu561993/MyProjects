//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NBK.Web.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeadTransferHistory
    {
        public System.Guid LeadHistoryID { get; set; }
        public System.Guid LeadID { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public string AssignedByRole { get; set; }
        public System.DateTime AssignDate { get; set; }
        public string Channel { get; set; }
        public string BranchNo { get; set; }
        public string Comments { get; set; }
    
        public virtual InstantLead InstantLead { get; set; }
    }
}
