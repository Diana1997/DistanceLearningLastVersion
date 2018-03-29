using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DistanceLearningLastVersion.Startup))]
namespace DistanceLearningLastVersion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
