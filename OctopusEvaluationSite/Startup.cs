using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctopusEvaluationSite.Startup))]
namespace OctopusEvaluationSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
