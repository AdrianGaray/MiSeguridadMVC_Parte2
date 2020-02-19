using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiSeguridadMVC_Parte2.Startup))]
namespace MiSeguridadMVC_Parte2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
