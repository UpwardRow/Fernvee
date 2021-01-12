using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FernveeAIT.Startup))]
namespace FernveeAIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
