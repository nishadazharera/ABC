using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthWindProject.Startup))]
namespace NorthWindProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
