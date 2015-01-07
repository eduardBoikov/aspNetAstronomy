using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(astronomy5.Startup))]
namespace astronomy5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
