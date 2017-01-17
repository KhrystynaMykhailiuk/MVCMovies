using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMovie_K.Startup))]
namespace MVCMovie_K
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
