using System;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using WhatsappAPI;

namespace Messenger.Controllers
{
    public class SmsController : TwilioController
    {
        public void Index(SmsRequest incomingMessage)
        {
            WAConf wa = new WAConf();
            wa.SendMessage("Your activity is now logged, Thankyou for your time", incomingMessage.From);
        }
    }
}
