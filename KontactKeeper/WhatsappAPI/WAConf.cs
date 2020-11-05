using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WhatsappAPI
{
    public class WAConf
    {
        public void SendMessage(string body, string to)
        {
            string accountSid = "ACbf8d1dcd97ee57e6f33ca2eb4046af72";
            string authToken = "3ee7bd95a410df16cac63ac610df06f0";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: body,
                from: new Twilio.Types.PhoneNumber("+12058904238"),
                to: new Twilio.Types.PhoneNumber(to)
            );

            Console.WriteLine(message.Sid);
        }
    }
}
