using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGitTest.Startup))]
namespace WebAppGitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
