using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SchoolSchedule.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SchoolSchedule.API
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager { get; set; }

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };

            var result = await _userManager.CreateAsync(user, userModel.Password);

            return result;
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            try
            {
                IdentityUser user = await _userManager.FindAsync(userName, password);
                //var userTEst = await _userManager.FindAsync(userName, password);
                //IdentityUser user = null;
                return user;
            }
            catch(Exception ex)
            {
                return null;
            }
          
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }

}