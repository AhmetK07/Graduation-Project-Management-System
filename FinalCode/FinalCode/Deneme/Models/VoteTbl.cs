//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Deneme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoteTbl
    {
        public int VoteID { get; set; }
        public string VoteDescription { get; set; }
        public Nullable<int> Rating { get; set; }
        public string VoteDescription2 { get; set; }
        public Nullable<int> Rating2 { get; set; }
        public string VoteDescription3 { get; set; }
        public Nullable<int> Rating3 { get; set; }
        public Nullable<System.DateTime> CommentedOn { get; set; }
        public Nullable<int> AssignGroup { get; set; }
    }
}
