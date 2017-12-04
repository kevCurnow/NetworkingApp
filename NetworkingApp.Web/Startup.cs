using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetworkingApp.Web.Startup))]
namespace NetworkingApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
