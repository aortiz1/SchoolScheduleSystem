using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.BusinessLayer.Contracts
{
    public interface ICoursesService
    {
        Task<List<Course>> GetCoursesByDegree(Guid degreeId);
        Task<List<Degree>> GetAllDegrees();
        Task<bool> RegisterToCourse(Guid courseId, Guid studentId);
        Task<List<UserCoursesView>> GetCoursesByStudent(Guid studentId, int semester);
        Task<List<RemainingCoursesSP_Result>> GetRemainingCourses(Guid? userId, Guid? degreeId);
    }
}
