using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameRating.Startup))]
namespace GameRating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
