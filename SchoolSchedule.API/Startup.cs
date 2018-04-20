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
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            ConfigureAuth(app);
        }
        
    }
}
