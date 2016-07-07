using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Search_ElasticSearch.Startup))]
namespace Search_ElasticSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
