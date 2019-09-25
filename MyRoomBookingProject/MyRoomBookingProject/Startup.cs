using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRoomBookingProject.Startup))]
namespace MyRoomBookingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
