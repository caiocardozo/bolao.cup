using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bolao.Cup.Web.Startup))]
namespace Bolao.Cup.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
