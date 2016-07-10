using IdentityServer3.Core.Configuration;
using Microsoft.Owin;
using Owin;
using SSODemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup("InMemory", typeof(Startup))]
namespace SSODemo
{
    public sealed class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map(
                "/core",
                coreApp =>
                {
                    coreApp.UseIdentityServer(new IdentityServerOptions
                    {
                        SiteName = "Standalone Identity Server",
                        SigningCertificate = Cert.Load(),
                        Factory =
                        new IdentityServerServiceFactory()
                            .UseInMemoryClients(Clients.Get())
                            .UseInMemoryScopes(Scopes.Get())
                            .UseInMemoryUsers(Users.Get()),
                        RequireSsl = true,
                        AuthenticationOptions = new AuthenticationOptions { EnablePostSignOutAutoRedirect = true }
                    });
                });
        }
    }
}