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
    
    public partial class Student_GroupTbl
    {
        public int StudentGroupID { get; set; }
        public int AssignStudentID { get; set; }
        public Nullable<int> AssignStudentID2 { get; set; }
        public int AssignGroupID { get; set; }
    
        public virtual GroupTbl GroupTbl { get; set; }
        public virtual StudentTbl StudentTbl { get; set; }
    }
}
