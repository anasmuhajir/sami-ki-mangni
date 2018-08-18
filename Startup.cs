using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Multiplebinding.Startup))]
namespace Multiplebinding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
