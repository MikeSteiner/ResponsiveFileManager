using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResponsiveFileManagerTest.Startup))]
namespace ResponsiveFileManagerTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
