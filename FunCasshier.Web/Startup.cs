using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunCasshier.Web.Startup))]
namespace FunCasshier.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
