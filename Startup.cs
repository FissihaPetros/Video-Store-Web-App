using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Video_Store_Web_App.Startup))]
namespace Video_Store_Web_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
