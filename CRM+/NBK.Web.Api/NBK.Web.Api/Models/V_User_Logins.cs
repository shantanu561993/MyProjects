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
    
    public partial class V_User_Logins
    {
        public int LoginID { get; set; }
        public string LoginAccount { get; set; }
        public Nullable<System.DateTime> LoginAccountStartDate { get; set; }
        public Nullable<System.DateTime> LoginAccountEndDate { get; set; }
        public int AssociatedLoginID { get; set; }
        public string AssociatedAccount { get; set; }
        public Nullable<System.DateTime> AssociatedAccountStartDate { get; set; }
        public Nullable<System.DateTime> AssociatedAccountEndDate { get; set; }
        public int PartyID { get; set; }
        public string NameEnglish { get; set; }
    }
}
