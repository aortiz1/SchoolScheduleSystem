using SchoolSchedule.BusinessLayer.Contracts;
using SchoolSchedule.DataLayer.Contracts;
using SchoolSchedule.DataLayer.Model;
using SchoolSchedule.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSchedule.Service.Service
{
    public class CoursesService : ICoursesService
    {
        private ICoursesRepository _coursesRepository;

        public CoursesService()
        {
            _coursesRepository = new CoursesRepository();
        }

        public async Task<List<Course>> GetCoursesByDegree(Guid degreeId)
        {
            return await _coursesRepository.GetCoursesByDegree(degreeId);
        }

        public async Task<List<Degree>> GetAllDegrees()
        {
            return await _coursesRepository.GetAllDegrees();
        }

        public async Task<bool> RegisterToCourse(Guid courseId, Guid studentId)
        {
            return await _coursesRepository.RegisterToCourse(courseId, studentId);
        }

        public async Task<List<UserCoursesView>> GetCoursesByStudent(Guid studentId, int semester)
        {
            return await _coursesRepository.GetCoursesByStudent(studentId, semester);
        }
        public async Task<List<RemainingCoursesSP_Result>> GetRemainingCourses(Guid? userId, Guid? degreeId)
        {
            return await _coursesRepository.GetRemainingCourses(userId, degreeId);
        }


    }
}
