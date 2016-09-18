using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunSeaSurgery.Startup))]
namespace SunSeaSurgery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
