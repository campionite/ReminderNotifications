using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Twilio;
using Twilio.Clients;
//using Twilio.Clients;

namespace ReminderNotifications.SmsApiClient
{
    public class TwilioClient
    {
        private readonly TwilioRestClient _client;

        private readonly string _accountSid = WebConfigurationManager.AppSettings["AccountSid"];
        private readonly string _authToken = WebConfigurationManager.AppSettings["AuthToken"];
        private readonly string _twilioNumber = WebConfigurationManager.AppSettings["TwilioNumber"];

        public TwilioClient()
        {
            _client = new TwilioRestClient(_accountSid, _authToken);
        }

        public void SendSmsMessage(string phoneNumber, string message)
        {
            //_client.SendMessage(_twilioNumber, phoneNumber, message);
            Debug.WriteLine("Message Sent !!!!!");
        }
    }
}
