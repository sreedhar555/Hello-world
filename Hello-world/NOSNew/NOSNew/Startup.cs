using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NOSNew.Startup))]
namespace NOSNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
