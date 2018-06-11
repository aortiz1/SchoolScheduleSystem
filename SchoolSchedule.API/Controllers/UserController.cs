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
using System.Security.Claims;

namespace SchoolSchedule.API.Controllers
{
    [Authorize]
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

        //[AllowAnonymous]
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

        

        [Route("GetUserLoggedInformation")]
        [HttpGet]
        public async Task<IHttpActionResult> GetUserLoggedInformation()
        {
            try
            {
                var user = (ClaimsIdentity)User.Identity;
                var claims = user.Claims;
                var email = (from u in user.Claims where u.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name" select u.Value).FirstOrDefault();

                var result = await _userService.GetUserByEmail(email);
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
