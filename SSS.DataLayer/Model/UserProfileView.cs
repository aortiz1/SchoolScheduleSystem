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
    
    public partial class UserProfileView
    {
        public System.Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> CurrentSemester { get; set; }
        public Nullable<bool> IsGraduated { get; set; }
        public Nullable<bool> IsExpelled { get; set; }
        public string AspNetUserId { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string Cellphone { get; set; }
        public Nullable<System.Guid> DegreeId { get; set; }
        public string Role { get; set; }
    }
}
