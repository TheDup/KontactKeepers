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
            var messageToSend = new MimeMessage
            {
                Body = new TextPart("plain") { Text = "Hello world!" },
                Subject = "Test",
            };
            messageToSend.From.Add(new MailboxAddress("ContactKeeper", "kontactkeeper@campus-kiosk.co.za"));
            messageToSend.To.Add(new MailboxAddress("JAMES", "devilliers.duplessis@gmail.com"));
            using (var client = new SmtpClient())
            {
                client.Connect("host21.axxesslocal.co.za", 465, true);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("KontactKeeper@campus-kiosk.co.za", "g4Ha2QtlMi7D");

                client.Send(messageToSend);
                client.Disconnect(true);
            }
        }
    }
}
