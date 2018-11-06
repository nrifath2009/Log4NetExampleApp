using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Log4NetExampleApp.Startup))]
namespace Log4NetExampleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
