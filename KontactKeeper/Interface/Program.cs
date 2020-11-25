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
                List<EndUser> endusers = cn.GetEndUsers();
                List<EmailUser> emailusers = cn.GetEmailUsers();
                
                foreach (EndUser enduser in endusers)
                {
                    string lastseen = emailConf.RecieveActivity(enduser.Email);
                    if (lastseen != "empty")
                    {
                        foreach (EmailUser emuser in emailusers)
                        {
                            if (enduser.Email == emuser.Email)
                            {
                                cn.UpdateEmailLastSeen(emuser.Email, lastseen, DateTime.Now.ToString());
                            }
                        }
                    }
                }
                Thread.Sleep(2147483647);
            }
        }
        public static async void tmethB()
        {
            Connector cn = new Connector();
            EmailConf em = new EmailConf();
            WAConf wa = new WAConf();
            Messenger fb = new Messenger();

            List<EndUser> users = cn.GetEndUsers();
            List<WAUser> wausers = cn.GetWAUsers();
            List<EmailUser> emusers = cn.GetEmailUsers();
            List<FBUser> fbusers = cn.GetFBUsers();

            string verifymessage = "Greetings, Please reply YES to confirm that you are still using this {0}. If any of your contact details have changed, please update it on the KontactKeeper website at https://KontactKeeper.com/contactdetails";
            string notifymessage = "Greetings, We haven't heard from you on {0} for a while, if your {1} have changed, please update it on the KontactKeeper website at https://KontactKeeper.com/contactdetails";

            foreach (EndUser user in users)
            {
                foreach (WAUser twa in wausers)
                {
                    if (twa.CellNumber == user.CellNumber)
                    {
                        DateTime now = DateTime.Now;
                        if (((now - DateTime.Parse(twa.LastSeen)).TotalDays > 90) && ((now - DateTime.Parse(twa.LastSent)).TotalDays > 90))
                        {
                            string message = string.Format(notifymessage, "Whatsapp", "phone number");
                            em.SendEmail(user.Email, message);
                            await fb.SendMessage(user.FBID, message);
                        }
                        else if ((now - DateTime.Parse(twa.LastSent)).TotalDays > 90)
                        {
                            wa.SendMessage(twa.CellNumber, string.Format(verifymessage, "phone number"));
                        }
                    }
                }

                foreach (EmailUser tem in emusers)
                {
                    if (tem.Email == user.Email)
                    {
                        DateTime now = DateTime.Now;
                        if (((now - DateTime.Parse(tem.LastSeen)).TotalDays > 90) && ((now - DateTime.Parse(tem.LastSent)).TotalDays > 90))
                        {
                            string message = string.Format(notifymessage, "Email", "email address");
                            wa.SendMessage(user.CellNumber, message);
                            await fb.SendMessage(user.FBID, message);
                        }
                        else if ((now - DateTime.Parse(tem.LastSent)).TotalDays > 90)
                        {
                            em.SendEmail(tem.Email, string.Format(verifymessage, "email address"));
                        }
                    }
                }

                foreach (FBUser tfb in fbusers)
                {
                    if (tfb.FBID == user.FBID)
                    {
                        DateTime now = DateTime.Now;
                        if (((now - (DateTime)(tfb.LastSeen)).TotalDays > 90) && ((now - DateTime.Parse(tfb.LastSent)).TotalDays > 90))
                        {
                            string message = string.Format(notifymessage, "Facebook", "facebook id");
                            em.SendEmail(user.Email, message);
                            await fb.SendMessage(user.FBID, message);
                        }
                        else if ((now - DateTime.Parse(tfb.LastSent)).TotalDays > 90)
                        {
                            wa.SendMessage(tfb.FBID, string.Format(verifymessage, "facebook account"));
                        }
                    }
                }
            }
        }
    }
}
