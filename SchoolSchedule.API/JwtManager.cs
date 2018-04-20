using SchoolSchedule.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Web.Configuration;
using JWT;

namespace SchoolSchedule.API
{
    public class JwtManager
    {
        

        /// <summary>
        /// Create a Jwt with user information
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dbUser"></param>
        /// <returns></returns>
        public static string CreateToken(User user, out object dbUser)
        {

            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var expiry = Math.Round((DateTime.UtcNow.AddMinutes(45) - unixEpoch).TotalSeconds);
            var issuedAt = Math.Round((DateTime.UtcNow - unixEpoch).TotalSeconds);
            var notBefore = Math.Round((DateTime.UtcNow.AddMonths(6) - unixEpoch).TotalSeconds);


            var payload = new Dictionary<string, object>
            {
                {"email", user.Email},
                {"userId", user.Id},
                //{"role", user.UserRoles},
                {"sub", user.Id},
                {"nbf", notBefore},
                {"iat", issuedAt},
                {"exp", expiry}
            };

            var secret = WebConfigurationManager.AppSettings.Get("jwtKey"); //secret key
            dbUser = new { user.Email, user.Id };
            var token = JsonWebToken.Encode(payload, secret, JwtHashAlgorithm.HS256);
            return token;
        }
    }


}