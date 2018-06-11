using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolSchedule.DataLayer.Contracts;

namespace SchoolSchedule.DataLayer.Repository
{
    public class CoursesRepository: ICoursesRepository
    {
        private SchoolScheduleDBEntities _context;

        public CoursesRepository()
        {
            _context = new SchoolScheduleDBEntities();
        }

        public async Task<List<Course>> GetCoursesByDegree(Guid degreeId)
        {
            try
            {
                
                var result = await _context.Courses.Where(c => c.DegreeId == degreeId).ToListAsync<Course>();
                return result;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
        public async Task<List<Degree>> GetAllDegrees()
        {
            try
            {
                var result = await _context.Degrees.ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }

        public async Task<List<RemainingCoursesSP_Result>> GetRemainingCourses(Guid? userId, Guid? degreeId)
        {
            try
            {
                var result =  _context.RemainingCoursesSP(userId, degreeId).ToList();
                return result;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }

        public async Task<bool> RegisterToCourse(Guid courseId, Guid studentId)
        {
            try
            {
                var semester = await (from u in _context.Users where u.Id == studentId select u.CurrentSemester).FirstOrDefaultAsync();
                var newRegister = new UserCourse()
                {
                    Id = Guid.NewGuid(),
                    Active = true,
                    CourseId = courseId,
                    UserId = studentId,
                    Created = DateTime.Now,
                    Semester = semester

                };
                _context.UserCourses.Add(newRegister);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
        public async Task<List<UserCoursesView>> GetCoursesByStudent(Guid studentId, int semester)
        {
            try
            {
                var result = await _context.UserCoursesViews.Where(x => x.Semester == semester && x.UserId == studentId).ToListAsync();
           
                return result;
            }
            catch (Exception e)
            {
                System.ArgumentException argEx = new System.ArgumentException("Exception", "An error occured on the database", e);
                throw argEx;
            }
        }
    }
}
