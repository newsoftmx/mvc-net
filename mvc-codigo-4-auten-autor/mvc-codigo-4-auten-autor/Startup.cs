using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_codigo_4_auten_autor.Startup))]
namespace mvc_codigo_4_auten_autor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
