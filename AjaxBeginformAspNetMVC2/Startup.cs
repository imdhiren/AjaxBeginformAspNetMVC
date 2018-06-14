using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxBeginformAspNetMVC2.Startup))]
namespace AjaxBeginformAspNetMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
