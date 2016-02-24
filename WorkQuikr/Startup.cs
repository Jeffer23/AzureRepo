using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkQuikr.Startup))]
namespace WorkQuikr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
