using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolSchedule.API.Models
{
    public class CreateUserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}