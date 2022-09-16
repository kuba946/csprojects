using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Missing.Startup))]
namespace Missing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
