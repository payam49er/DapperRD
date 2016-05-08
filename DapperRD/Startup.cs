using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DapperRD.Startup))]
namespace DapperRD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
