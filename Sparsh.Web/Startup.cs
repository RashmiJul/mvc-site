using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sparsh.Web.Startup))]
namespace Sparsh.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
