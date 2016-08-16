using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCCLLIS.Startup))]
namespace SCCLLIS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
