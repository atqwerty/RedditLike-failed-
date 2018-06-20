using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedditLike.Startup))]
namespace RedditLike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
