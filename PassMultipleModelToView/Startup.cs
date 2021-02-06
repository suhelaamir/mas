using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleModelToTheView.Startup))]
namespace MultipleModelToTheView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
