using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NWT_Twitter.Startup))]
namespace NWT_Twitter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
