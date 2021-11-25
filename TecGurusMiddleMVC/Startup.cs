using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TecGurusMiddleMVC.Startup))]
namespace TecGurusMiddleMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
