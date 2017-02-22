using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeEditor.Startup))]
namespace ResumeEditor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
