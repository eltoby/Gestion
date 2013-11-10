using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestion.Web.Startup))]
namespace Gestion.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
