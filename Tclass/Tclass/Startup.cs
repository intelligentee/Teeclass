using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tclass.Startup))]
namespace Tclass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
