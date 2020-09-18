using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admEstudianteSeguro.Startup))]
namespace admEstudianteSeguro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
