using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityExternalLogins.Startup))]
namespace IdentityExternalLogins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
