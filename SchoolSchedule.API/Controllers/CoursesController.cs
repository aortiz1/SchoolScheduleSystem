using ExpressMapper;
using SchoolSchedule.API.Models;
using SchoolSchedule.BusinessLayer.Contracts;
using SchoolSchedule.DataLayer.Model;
using SchoolSchedule.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SchoolSchedule.API.Controllers
{
    [RoutePrefix("api/Courses")]
    //[EnableCors("*", "*", "*")]
    [Authorize]
    public class CoursesController : ApiController
    {
        private ICoursesService _coursesService;
        public CoursesController()
        {
            _coursesService = new CoursesService();
        }

        private void RegisterMappings()
        {
          Mapper.Register<Degree, DegreeDTO>();
        }

        [Route("GetCoursesByDegree")]
        [HttpPost]
        public async Task<IHttpActionResult> GetCoursesByDegree(Guid degreeId)
        {
            try
            {
                var result = await _coursesService.GetCoursesByDegree(degreeId);
                return Ok(new { success = true, result =  result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [Route("GetAllDegrees")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAllDegrees()
        {
            try
            {
                var query = await _coursesService.GetAllDegrees();
                var result = Mapper.Map<List<Degree>, List<DegreeDTO>>(query);
                return Ok(new { success = true, result = result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
        [Route("RegisterToCourse")]
        [HttpPost]
        public async Task<IHttpActionResult> RegisterToCourse(Guid courseId, Guid studentId)
        {
            try
            {
                var query = await _coursesService.RegisterToCourse(courseId, studentId);
                string message = "";
                if (query)
                    message = "Subscribed to course";
                else
                    message = "Couldn't subscribe to course";

                return Ok(new { success = query, result = message });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [Route("GetCoursesByStudent")]
        [HttpGet]
        public async Task<IHttpActionResult> GetCoursesByStudent(Guid studentId, int semester)
        {
            try
            {
                var result = await _coursesService.GetCoursesByStudent(studentId, semester);

                return Ok(new { success = true, result = result});
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }
}
