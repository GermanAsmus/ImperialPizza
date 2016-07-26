using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImperialPizza.Startup))]
namespace ImperialPizza
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
