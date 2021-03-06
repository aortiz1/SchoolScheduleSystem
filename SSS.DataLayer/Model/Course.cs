//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolSchedule.DataLayer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.UserCourses = new HashSet<UserCourse>();
        }
    
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        public Nullable<int> MinimunSemesterAllowed { get; set; }
        public Nullable<System.Guid> PreviousCourseId { get; set; }
        public Nullable<System.Guid> DegreeId { get; set; }
    
        public virtual Degree Degree { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
