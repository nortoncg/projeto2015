using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppLP2015.Startup))]
namespace WebAppLP2015
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
