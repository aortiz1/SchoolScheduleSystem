using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolSchedule.DataLayer.Model;
using SchoolSchedule.Service.Contracts;
using SchoolSchedule.Service.Service;
using System.Threading.Tasks;

namespace SchoolSchedule.API.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        [Route("AddNewUser")]
        public async Task<IHttpActionResult> AddNewUser(User user)
        {
            Guid result = await _userService.AddNewUser(user);
            return Ok(result);
        }
    }
}
