using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjCodeFirstUsers.Startup))]
namespace EjCodeFirstUsers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
