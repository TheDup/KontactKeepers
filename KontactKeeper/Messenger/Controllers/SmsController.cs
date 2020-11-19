using System;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using WhatsappAPI;
using BusinessLogic;
using System.Data.SqlTypes;

namespace Messenger.Controllers
{
    public class SmsController : TwilioController
    {
        public void Index(SmsRequest incomingMessage)
        {
            WAConf wa = new WAConf();
            Connector cn = new Connector();
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            cn.AddWAUser(incomingMessage.From, SqlDateTime.Parse(sqlFormattedDate));
            wa.SendMessage("Your activity is now logged, Thankyou for your time", incomingMessage.From);
        }
    }
}
