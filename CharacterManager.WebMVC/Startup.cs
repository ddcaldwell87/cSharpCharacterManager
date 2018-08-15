using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharacterManager.WebMVC.Startup))]
namespace CharacterManager.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
