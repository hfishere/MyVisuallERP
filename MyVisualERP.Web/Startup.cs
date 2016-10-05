using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyVisualERP.Web.Startup))]
namespace MyVisualERP.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
