using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeoAcademy.Startup))]
namespace GeoAcademy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
