using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitMVCApp.Startup))]
namespace TestGitMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
