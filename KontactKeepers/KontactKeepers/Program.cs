using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontactKeepers
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailConf econf = new EmailConf();

            var messageToSend = new MimeMessage
            {
                Body = new TextPart("plain") { Text = "Someone added encapsulation and object usage" },
                Subject = "Greetings",
            };
            messageToSend.From.Add(new MailboxAddress("ContactKeeper", econf.EmailAddressUName));
            messageToSend.To.Add(new MailboxAddress("Piet", "petervorster9@gmail.com"));
            using (var client = new SmtpClient())
            {
                client.Connect(econf.OutgoingServer, int.Parse(econf.SmtpPort), true);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(econf.EmailAddressUName, econf.MailPass);

                client.Send(messageToSend);
                client.Disconnect(true);
            }
        }
    }
}
