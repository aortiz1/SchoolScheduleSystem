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
    
    public partial class UserCoursesView
    {
        public System.Guid UserId { get; set; }
        public string StudentName { get; set; }
        public Nullable<System.Guid> DegreeId { get; set; }
        public string Degree { get; set; }
        public System.Guid CourseId { get; set; }
        public string Course { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> Semester { get; set; }
    }
}
