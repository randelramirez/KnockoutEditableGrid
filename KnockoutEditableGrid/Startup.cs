using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockoutEditableGrid.Startup))]
namespace KnockoutEditableGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
