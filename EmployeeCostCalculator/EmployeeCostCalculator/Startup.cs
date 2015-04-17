using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeCostCalculator.Startup))]
namespace EmployeeCostCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
