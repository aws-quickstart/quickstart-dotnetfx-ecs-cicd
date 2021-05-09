using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5App.Startup))]
namespace MVC5App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
