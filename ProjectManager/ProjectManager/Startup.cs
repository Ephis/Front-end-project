using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectManager.Startup))]
namespace ProjectManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureAuth(app);

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
