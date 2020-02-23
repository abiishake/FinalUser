using FinalUser.Infrastructure;
using Microsoft.AspNet.Identity;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalUser.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<AppIdentityDbContext>(AppIdentityDbContext.Create);
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);

            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions { AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie, LoginPath = new Microsoft.Owin.PathString("/Account/Login") });
        }
    }
}