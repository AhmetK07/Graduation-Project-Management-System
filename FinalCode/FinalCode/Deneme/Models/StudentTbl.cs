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
    
    public partial class StudentTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentTbl()
        {
            this.FeedbackTbl = new HashSet<FeedbackTbl>();
            this.GradeTbl = new HashSet<GradeTbl>();
            this.Student_GroupTbl = new HashSet<Student_GroupTbl>();
            this.Student_ProjectTbl = new HashSet<Student_ProjectTbl>();
            this.TaskTbl = new HashSet<TaskTbl>();
        }
    
        public int StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string StudentEmail { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string Password { get; set; }
        public string StudentPhoto { get; set; }
        public string StudentPhone { get; set; }
        public Nullable<int> AssignProject { get; set; }
        public Nullable<int> AssignProfessor { get; set; }
        public Nullable<int> RemainAppeal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackTbl> FeedbackTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeTbl> GradeTbl { get; set; }
        public virtual ProfessorTbl ProfessorTbl { get; set; }
        public virtual ProjectTbl ProjectTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_GroupTbl> Student_GroupTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_ProjectTbl> Student_ProjectTbl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskTbl> TaskTbl { get; set; }
    }
}