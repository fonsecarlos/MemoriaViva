using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MemoriaViva.Startup))]
namespace MemoriaViva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
