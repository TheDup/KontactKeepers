using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BusinessLogic;
using EmailAPI;


namespace Interface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
            Thread emailThread = new Thread(tmeth);
            emailThread.Start();

        }
        public static void tmeth()
        {

            EmailConf emailConf = new EmailConf();
            while(true)
            {

                Connector cn = new Connector();
                //List<EmailUser> emailClients =cn.
                List<EndUser> enusers= cn.GetEndUsers();
                List<EmailUser> emails = cn.GetEmailUsers();
                foreach (EmailUser email in emails)
                {

                    email.LastSeen = emailConf.RecieveActivity(email.Email);
                    cn.UpdateEmailLastSeen(email.Email, email.LastSeen);
                }
                Thread.Sleep(2147483647);
            }
        }
    }
}
