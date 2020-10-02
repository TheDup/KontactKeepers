using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class Connector
    {
        public List<Admin> GetAdmins()
        {
            DataHandler dh = new DataHandler();
            List<Admin> admins = new List<Admin>();
            DataTable dt = dh.Read("tblAdmin");
            foreach (DataRow row in dt.Rows)
            {
                admins.Add(new Admin(row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            return admins;
        }

        public List<FBUser> GetFBUsers()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.Read("tblFBUser");
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
        public void AddAdmin(string fname, string lname, string uname, string password)
        {
            DataHandler dh = new DataHandler();
            dh.AddAdmin(fname, lname, uname, password);
        }

        public void UpdateAdmin(string pidadmin, string fname, string lname, string uname, string password)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteAdmin(pidadmin);
            dh.AddAdmin( fname, lname, uname, password);
        }

        public void DeleteAdmin(string pidadmin)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteAdmin(pidadmin);
        }
    }
}
