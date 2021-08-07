using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Smart_Store.Web.Startup))]
namespace Smart_Store.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
