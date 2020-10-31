using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using fbchat_sharp.API;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using BusinessLogic;

namespace FacebookAPI
{
    public class FBConf
    {
        private static Client client;
        public static async Task Login(string email, string password)
        {
            client = new Client();
            try
            {
                await client.login(email, password);
                if (await client.isLoggedIn())
                {
                    Console.WriteLine("logged");
                }
                else
                {
                    throw new CustomException("Facebook login error");
                }
            }
            catch (CustomException cex)
            {
                Console.WriteLine(cex.Message);
            }


            Thread th = new Thread(new ThreadStart(Tmeth));
            th.Start();
        }
        public static void Tmeth()
        {
            FbPoll(client);
        }
        public static async Task FbPoll(Client client)
        {
            while (true)
            {
                //users on messenger
                List<FB_User> remusers = await client.fetchAllUsers();
                List<string> userid = new List<string>();
                foreach (FB_User item in remusers)
                {
                    userid.Add(item.uid);
                }
                Dictionary<string, FB_Thread> dictusers = await client.fetchThreadInfo(userid);

                //active users on messenger
                List<string> activeusers = await client.fetchActiveUsers();
                foreach (string item in activeusers)
                {
                    Console.WriteLine(item);
                }

                //users in database
                Connector cn = new Connector();
                List<FBUser> localusers = cn.GetFBUsers();
                List<string> localids = new List<string>();
                foreach (FBUser item in localusers)
                {
                    localids.Add(item.FBID);
                }

                foreach (KeyValuePair<string, FB_Thread> item in dictusers)
                {
                    if (!localids.Contains(item.Key))
                    {

                        //add user to db
                        DateTime time = new DateTime();
                        time = DateTime.Now;
                        cn.AddFBUser(item.Key, item.Value.name, SqlDateTime.Parse(time.ToString()));
                    }

                    if (activeusers.Contains(item.Key))
                    {
                        //update last seen
                        DateTime time = new DateTime();
                        time = DateTime.Now;
                        cn.UpdateFBLastSeen(item.Key, item.Value.name, SqlDateTime.Parse(time.ToString()));
                    }
                }

                Thread.Sleep(1000);
            }
        }
    }
}
