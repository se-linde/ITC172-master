using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProjV2.Startup))]
namespace FinalProjV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
