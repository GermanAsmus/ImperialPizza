using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaMVC.Startup))]
namespace PizzaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
