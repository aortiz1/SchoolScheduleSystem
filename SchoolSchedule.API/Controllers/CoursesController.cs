using SchoolSchedule.BusinessLayer.Contracts;
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
    [RoutePrefix("api/Account")]
    [EnableCors("*", "*", "*")]
    public class CoursesController : ApiController
    {
        private ICoursesService _coursesService;
        public CoursesController()
        {
            _coursesService = new CoursesService();
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

        [Route("GetCoursesByDegree")]
        [HttpPost]
        public async Task<IHttpActionResult> GetCoursesByDegree(Guid degreeId)
        {
            try
            {
                var result = await _coursesService.GetCoursesByDegree(degreeId);
                return Ok(new { success = true, result = result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }
}
