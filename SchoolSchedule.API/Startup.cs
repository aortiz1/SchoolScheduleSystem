using System;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.OAuth;
using SchoolSchedule.API.Providers;
using System.Web.Http;

[assembly: OwinStartup(typeof(SchoolSchedule.API.Startup))]

namespace SchoolSchedule.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureAuth(app);
            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);

        }
        //public void ConfigureOAuth(IAppBuilder app)
        //{

        //    OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
        //    {
        //        //For Dev enviroment only (on production should be AllowInsecureHttp = false)
        //        AllowInsecureHttp = true,
        //        TokenEndpointPath = new PathString("/token"),
        //        AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
        //        Provider = new ApplicationOAuthProvider(),
        //        AccessTokenFormat = new CustomJwtFormat("http://jwtauthzsrv.azurewebsites.net")
        //    };

        //    // OAuth 2.0 Bearer Access Token Generation
        //    app.UseOAuthAuthorizationServer(OAuthServerOptions);

        //}
    }
}
