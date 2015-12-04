using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessageApp.Startup))]
namespace MessageApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
