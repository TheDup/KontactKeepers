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
            econf.SendActivityEmail("jannesventer09@gmail.com");
        }
    }
}
