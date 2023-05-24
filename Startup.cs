using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arta.Startup))]
namespace Arta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
