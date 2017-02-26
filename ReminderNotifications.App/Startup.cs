using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using ReminderNotifications.App.Hangfire;

[assembly: OwinStartup(typeof(ReminderNotifications.App.Startup))]

namespace ReminderNotifications.App
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            HangfireStartup.ConfigureHangfire(app);
            HangfireStartup.InitializeJobs();

        }
    }
}
