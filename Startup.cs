using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Epandemia.Startup))]
namespace Epandemia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
