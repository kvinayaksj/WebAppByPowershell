using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCICDDemo.Startup))]
namespace WebCICDDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
