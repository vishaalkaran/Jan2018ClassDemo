using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jan2018ClassDemoVincentWebsite.Startup))]
namespace Jan2018ClassDemoVincentWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
