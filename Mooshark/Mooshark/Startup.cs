using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mooshark.Startup))]
namespace Mooshark
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
