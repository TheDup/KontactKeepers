using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BusinessLogic;
using EmailAPI;
using WhatsappAPI;
using FBSendAPI;


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
            Thread emailThread = new Thread(tmethA);
            emailThread.Start();
            Thread notify = new Thread(tmethB);
            notify.Start();
        }
        public static void tmethA()
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
                    cn.UpdateEmailLastSeen(email.Email, email.LastSeen, email.LastSent);
                }
                Thread.Sleep(2147483647);
            }
        }
        public static void tmethB()
        {
            Connector cn = new Connector();
            List<EndUser> users = cn.GetEndUsers();
            //email
            EmailConf em = new EmailConf();
            //whatsapp
            WAConf wa = new WAConf();
            //facebook
            Messenger ms = new Messenger();

            List<WAUser> wausers = cn.GetWAUsers();
            List<EmailUser> emusers = cn.GetEmailUsers();
            List<FBUser> fbusers = cn.GetFBUsers();

            //datediff

            foreach (EndUser user in users)
            {
                foreach (WAUser twa in wausers)
                {
                    if (twa.CellNumber == user.CellNumber)
                    {
                        DateTime current = DateTime.Now;
                        if ((DateTime.Parse(twa.LastSent) - DateTime.Parse(twa.LastSeen)).TotalDays >= 90)
                        {
                            wa.SendMessage("Please reply YES to confirm activity", twa.CellNumber);
                        }
                    }

                }
                foreach (EmailUser tem in emusers)
                {
                    if (true)
                    {
                        DateTime current = DateTime.Now;
                        if ((DateTime.Parse(tem.LastSent) - DateTime.Parse(tem.LastSeen)).TotalDays >= 90)
                        {
                            em.SendActivityEmail(tem.Email);
                        }
                    }

                }
                foreach (FBUser tfb in fbusers)
                {
                    if (true)
                    {
                        DateTime current = DateTime.Now;
                        if ((DateTime.Parse(tfb.LastSent) - DateTime.Parse(tfb.LastSeen.ToString())).TotalDays >= 90)
                        {
                            ms.SendMessageAsync(tfb.FBID);
                        }
                    }

                }

                em.SendActivityEmail(user.Email);
                wa.SendMessage("Please reply Yes to confirm activity" ,user.CellNumber);
                ms.SendMessageAsync(user.FBID);
            }
        }
    }
}
