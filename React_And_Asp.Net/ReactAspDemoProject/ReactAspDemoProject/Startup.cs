using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactAspDemoProject.Startup))]
namespace ReactAspDemoProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
