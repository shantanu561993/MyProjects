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
    
    public partial class InstantLeadMap
    {
        public int MapID { get; set; }
        public int TypeID { get; set; }
        public string MapValue { get; set; }
        public Nullable<int> Map2TypeID { get; set; }
    
        public virtual InstantLeadType InstantLeadType { get; set; }
    }
}