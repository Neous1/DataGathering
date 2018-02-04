using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDataGathering.Startup))]
namespace WebDataGathering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
