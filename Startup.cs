using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tommys_Place.Startup))]
namespace Tommys_Place
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
