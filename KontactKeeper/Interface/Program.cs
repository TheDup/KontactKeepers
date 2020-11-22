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
            for (int i = 0; i < 10; i++)
            {

                Connector cn = new Connector();
                //List<EmailUser> emailClients =cn.
                List<EndUser> eusers= cn.GetEndUsers();
                List<string> emails;
                foreach (EndUser eUser in emailClients)
                {
                    eUser.emailConf.RecieveActivity()
                        cn.UpdateEndUser()

                }
                Thread.Sleep(2147483647);
            }
        }
    }
}
