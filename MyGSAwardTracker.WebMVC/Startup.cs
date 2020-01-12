using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGSAwardTracker.WebMVC.Startup))]
namespace MyGSAwardTracker.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
