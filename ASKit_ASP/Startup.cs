using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASKit_ASP.Startup))]
namespace ASKit_ASP
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
