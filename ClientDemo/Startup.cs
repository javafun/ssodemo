using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.IdentityModel.Tokens;
using System.Collections.Generic;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security;

[assembly: OwinStartup(typeof(ClientDemo.Startup))]

namespace ClientDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            JwtSecurityTokenHandler.InboundClaimTypeMap = new Dictionary<string, string>();

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "TempCookie",
                AuthenticationMode = AuthenticationMode.Passive
            });
        }
    }
}
