using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLearning1.Startup))]
namespace MVCLearning1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
