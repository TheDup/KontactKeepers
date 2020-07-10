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
            EmailConf ec = new EmailConf();

            var messageToSend = new MimeMessage
            {
                Body = new TextPart("plain") { Text = "Someone added encapsulation and object usage" },
                Subject = "Greetings",
            };
            messageToSend.From.Add(new MailboxAddress("ContactKeeper", ec.EmailAddressUName));
            messageToSend.To.Add(new MailboxAddress("DeVilliers", "devilliers.duplessis@gmail.com"));
            using (var client = new SmtpClient())
            {
                client.Connect(ec.OutgoingServer, int.Parse(ec.SmtpPort), true);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(ec.EmailAddressUName, ec.MailPass);

                client.Send(messageToSend);
                client.Disconnect(true);
            }
        }
    }
}
