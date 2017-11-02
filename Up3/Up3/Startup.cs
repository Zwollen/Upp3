using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Up3.Startup))]
namespace Up3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
