using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFT.Startup))]
namespace EFT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
