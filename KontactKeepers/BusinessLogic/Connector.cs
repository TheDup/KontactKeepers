using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Connector
    {
        public List<FBUser> GetFBUsers()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.Read("FBUsers");
            List<FBUser> users = new List<FBUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new FBUser(row[1].ToString(), row[2].ToString(), SqlDateTime.Parse(row[3].ToString())));
            }
            return users;
        }
        public void AddFBUser(string fbid, string name, SqlDateTime lastseen)
        {
            DataHandler dh = new DataHandler();
            dh.AddUser(fbid, name, lastseen);
        }
        public void UpdateFBLastSeen(string fbid, string name, SqlDateTime lastseen)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteUser(fbid);
            dh.AddUser(fbid, name, lastseen);
        }
    }
}
