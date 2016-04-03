using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBeginner.Startup))]
namespace WebBeginner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
