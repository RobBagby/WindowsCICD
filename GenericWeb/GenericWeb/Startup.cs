using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GenericWeb.Startup))]
namespace GenericWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
