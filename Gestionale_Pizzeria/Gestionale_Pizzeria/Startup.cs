using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestionale_Pizzeria.Startup))]
namespace Gestionale_Pizzeria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
