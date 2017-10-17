using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ivan.Startup))]
namespace Ivan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
