using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

using SchoolSchedule.DataLayer.Model;
using SchoolSchedule.Service.Contracts;
using SchoolSchedule.Service.Service;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace SchoolSchedule.API.Controllers
{
    [Authorize]
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        private IUserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }

        [Route("AddNewUser")]
        [HttpPut]
        public async Task<IHttpActionResult> AddNewUser(User user)
        {
            try {   
                Guid result = await _userService.AddNewUser(user);
                return Ok(new { success= true, result = result});
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
            
        }

        [Route("UpdateUserInformation")]
        [HttpPost]
        public async Task<IHttpActionResult> UpdateUserInformation([FromBody] User user)
        {
            try
            {
                var result = await _userService.UpdateUserInformation(user);
                return Ok(new { success = true, result = "User Updated" });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [Route("GetUserInformation")]
        [HttpGet]
        public async Task<IHttpActionResult> GetUserInformation(Guid? userId)
        {
            try
            {
                var result = await _userService.GetUserInformation(userId);
                return Ok(new { success = true, result = result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [Route("GetAllUsers")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GetAllUsers()
        {
            try
            {
                var result = await _userService.GetAllUsers();
                return Ok(new { success = true, result = result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [Route("GenerateMockUsers")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IHttpActionResult> GenerateMockUsers(int totalRegisters)
        {
            try
            {
                var result = await _userService.GenerateMockUsers(totalRegisters);
                return Ok(new { success = true, result = result });
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }


    }
}
