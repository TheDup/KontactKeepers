using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontactKeepers
{
    class EmailConf
    {
        private string emailAddressUName = "KontactKeeper@campus-kiosk.co.za";
        private string mailPass = "g4Ha2QtlMi7D";
        private string incomingSSLServer = "host21.axxesslocal.co.za";
        private string imapPort = "993";
        private string pop3Port = "995";
        private string outgoingServer = "host21.axxesslocal.co.za";
        private string smtpPort = "465";

        public string EmailAddressUName { get => emailAddressUName; set => emailAddressUName = value; }
        public string MailPass { get => mailPass; set => mailPass = value; }
        public string IncomingSSLServer { get => incomingSSLServer; set => incomingSSLServer = value; }
        public string ImapPort { get => imapPort; set => imapPort = value; }
        public string Pop3Port { get => pop3Port; set => pop3Port = value; }
        public string OutgoingServer { get => outgoingServer; set => outgoingServer = value; }
        public string SmtpPort { get => smtpPort; set => smtpPort = value; }

        // Non SSL settings
        //Username: Your Email Address
        //Incoming Server: Your Domain
        //IMAP Port: 143
        //POP3 Port: 110
        //Outgoing Server: Your Domain
        //SMTP Port: 25


    }
}
