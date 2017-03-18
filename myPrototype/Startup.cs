using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myPrototype.Startup))]
namespace myPrototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
