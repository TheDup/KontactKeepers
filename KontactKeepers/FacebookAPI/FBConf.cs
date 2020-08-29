using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fbchat_sharp.API;

namespace FacebookAPI
{
    class FBConf
    {
        public static async Task Login()
        {
            Client client = new Client();
            await client.login("", "");//email and password for kontactkeeper facebook account
            if (await client.isLoggedIn())
            {
                Console.WriteLine("logged");
            }
            else
            {
                Console.WriteLine("not logged");
            }

            Console.WriteLine("");
            Console.WriteLine("Users online (ID):");

            List<string> users = await client.fetchActiveUsers();
            Dictionary<string, FB_Thread> dict = await client.fetchThreadInfo(users);
            foreach (KeyValuePair<string, FB_Thread> item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.name);
                Console.WriteLine();
            }
        }
    }
}
