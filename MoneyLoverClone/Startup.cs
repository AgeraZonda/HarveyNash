using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyLoverClone.Startup))]
namespace MoneyLoverClone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
