using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SchoolSchedule.DataLayer.Repository
{
    public class CoursesRepository
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
                var result = await _context.Courses.Where(c => c.DegreeId == degreeId).ToListAsync();
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
    }
}
