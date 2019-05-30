using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200393765_quiz.Startup))]
namespace _200393765_quiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
