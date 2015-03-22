using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myFirstApp.Startup))]
namespace myFirstApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
