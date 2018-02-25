using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TR.WebUI.Startup))]
namespace TR.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
