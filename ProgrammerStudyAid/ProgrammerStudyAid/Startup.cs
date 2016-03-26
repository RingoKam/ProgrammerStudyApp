using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgrammerStudyAid.Startup))]
namespace ProgrammerStudyAid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
