using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestVue.Startup))]
namespace TestVue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
