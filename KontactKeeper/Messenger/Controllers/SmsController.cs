﻿using System;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;
using WhatsappAPI;
using BusinessLogic;
using System.Data.SqlTypes;
using System.Collections.Generic;

namespace Messenger.Controllers
{
    public class SmsController : TwilioController
    {
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            Connector cn = new Connector();
            List<WAUser> users = cn.GetWAUsers();

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            bool found = false;

            string from = incomingMessage.From.ToString();
            foreach (WAUser user in users)
            {
                if (user.CellNumber == from)
                {
                    found = true;
                    cn.UpdateWALastSeen(from, sqlFormattedDate, user.LastSent);
                }
            }


            if (found == false)
            {
                cn.AddWAUser(from, sqlFormattedDate, "2001-09-11 8:46:40.000");
            }
            //cn.AddWAUser("0721752576", "2020-11-12 12:10:10.000"));
            var messagingResponse = new MessagingResponse();
            messagingResponse.Message("Activity reported, Thank you!");
            return TwiML(messagingResponse);
        }
    }
}
