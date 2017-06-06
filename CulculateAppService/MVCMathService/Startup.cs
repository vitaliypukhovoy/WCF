using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMathService.Startup))]
namespace MVCMathService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
