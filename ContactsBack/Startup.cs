using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsBack.Startup))]
namespace ContactsBack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
