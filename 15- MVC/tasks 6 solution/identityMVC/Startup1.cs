using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(identityMVC.Startup1))]

namespace identityMVC
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "AppCookie", //cookie file which we be made
                LoginPath = new PathString("/Account/Login") //lama tefshal fi dekhol ay page wadeni el login 
            });
        }
    }
}
