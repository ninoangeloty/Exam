using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FPExam.Web.Startup))]
namespace FPExam.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
