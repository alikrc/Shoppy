using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shoppy.Web.Startup))]
namespace Shoppy.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
