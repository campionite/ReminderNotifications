using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderNotifications.Jobs
{
    public class NotificationJob
    {
        private const string MessageTemplate =
            "Hi {0}. Just a reminder that you have an appointment coming up at {1}.";

        public void Execute()
        {
            var twilioRestClient = new ReminderNotifications.SmsApiClient.TwilioClient();// Domain.Twilio.RestClient();

            //AvailableAppointments().ForEach(appointment =>
            //    twilioRestClient.SendSmsMessage(
            //    appointment.PhoneNumber,
            //    string.Format(MessageTemplate, appointment.Name, appointment.Time.ToString("t"))));

            twilioRestClient.SendSmsMessage("", "");
                
               
        }

        //private static IEnumerable<Appointment> AvailableAppointments()
        //{
        //    return new AppointmentsFinder(new AppointmentRepository(), new TimeConverter())
        //        .FindAvailableAppointments(DateTime.Now);
        //}
    }
}
