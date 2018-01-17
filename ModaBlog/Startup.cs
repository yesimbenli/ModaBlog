using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModaBlog.Startup))]
namespace ModaBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
