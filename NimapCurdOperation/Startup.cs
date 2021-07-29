using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NimapCurdOperation.Startup))]
namespace NimapCurdOperation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
