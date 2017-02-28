using Hangfire;
using Owin;
using ReminderNotifications.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReminderNotifications.App.Hangfire
{
    public class HangfireStartup
    {
        public static void ConfigureHangfire(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage(@"Server = localhost\SQLEXPRESS; Database = HangfireDB; Trusted_Connection = True;");
            //This uses a local instance of a SQL Express database.

            app.UseHangfireDashboard("/jobs");
            app.UseHangfireServer();
        }

        public static void InitializeJobs()
        {
            RecurringJob.AddOrUpdate<NotificationJob>(job => job.Execute(), Cron.Minutely);
        }
    }
}