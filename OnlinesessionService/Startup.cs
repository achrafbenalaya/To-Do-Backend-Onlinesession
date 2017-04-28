using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OnlinesessionService.Startup))]

namespace OnlinesessionService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}