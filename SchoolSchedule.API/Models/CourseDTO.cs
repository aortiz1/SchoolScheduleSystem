using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSchedule.API.Models
{
    public class CourseDTO
    {
        public System.Guid Id { get; set; }
        public string Description { get; set; }
        public Nullable<int> MinimunSemesterAllowed { get; set; }
        public Nullable<System.Guid> PreviousCourseId { get; set; }
        public Nullable<System.Guid> DegreeId { get; set; }
    }
}