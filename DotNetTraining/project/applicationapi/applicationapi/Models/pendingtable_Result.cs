//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace applicationapi.Models
{
    using System;
    
    public partial class pendingtable_Result
    {
        public int Requestid { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public Nullable<int> UserId { get; set; }
        public string CurrentStatus { get; set; }
    }
}
