using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.DataLayer.Contracts
{
    public interface ICoursesRepository
    {
        Task<List<Course>> GetCoursesByDegree(Guid degreeId);
        Task<List<Degree>> GetAllDegrees();
        Task<bool> RegisterToCourse(Guid courseId, Guid studentId);
        Task<List<UserCourse>> GetCoursesByStudent(Guid studentId, int semester);

    }
}
