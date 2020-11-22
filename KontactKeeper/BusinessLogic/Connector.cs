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
        ///////////////////////////////////////ADMINS/////////////////////////////////////////////////////////
        public List<Admin> GetAdmins()
        {
            DataHandler dh = new DataHandler();
            List<Admin> admins = new List<Admin>();
            DataTable dt = dh.Read("tblAdmin");
            foreach (DataRow row in dt.Rows)
            {
                admins.Add(new Admin(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            return admins;
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
            dh.AddAdmin(fname, lname, uname, password);
        }

        public void DeleteAdmin(string pidadmin)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteAdmin(pidadmin);
        }
        /////////////////////////////////////////FBUSERS////////////////////////////////////////////////////
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
            dh.AddFBUser(fbid, name, lastseen);
        }
        public void UpdateFBLastSeen(string fbid, string name, SqlDateTime lastseen)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteFBUser(fbid);
            dh.AddFBUser(fbid, name, lastseen);
        }
        /////////////////////////////////////////WAUSERS////////////////////////////////////////////////////
        public List<WAUser> GetWAUsers()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.Read("tblWAUser");
            List<WAUser> users = new List<WAUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new WAUser(row[1].ToString(), row[2].ToString()));
            }
            return users;
        }
        public int AddWAUser(string phone, string lastseen)
        {
            DataHandler dh = new DataHandler();
            return dh.AddWAUser(phone, lastseen);
        }
        public int UpdateWALastSeen(string phone, string lastseen)
        {
            DataHandler dh = new DataHandler();
            return dh.DeleteWAUser(phone) + dh.AddWAUser(phone, lastseen);
        }
        //////////////////////////////////////////////////ENDUSERS///////////////////////////////
        public List<EndUser> GetEndUsers()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.Read("tblEndUser");
            List<EndUser> users = new List<EndUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
            }
            return users;
        }
        public void AddEndUser(string fname, string lname, string uname, string password, string cellnumber, bool waverified, string email, bool emailverified, string fbid, bool fbverified)
        {
            DataHandler dh = new DataHandler();
            dh.AddEndUser(fname, lname, uname, password, cellnumber, waverified, email, emailverified, fbid, fbverified);
        }
        public void UpdateEndUser(string pidenduser, string fname, string lname, string uname, string password, string cellnumber, bool waverified, string email, bool emailverified, string fbid, bool fbverified)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteEndUser(pidenduser);
            dh.AddEndUser(fname, lname, uname, password, cellnumber, waverified, email, emailverified, fbid, fbverified);
        }
        public void DeleteEndUser(string pidenduser)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteEndUser(pidenduser);
        }
        /////////////////////////////////////////////CALLAGENTS///////////////////////////////////
        public List<Agent> GetCallAgents()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.Read("tblCallAgent");
            List<Agent> agents = new List<Agent>();
            foreach (DataRow row in dt.Rows)
            {
                agents.Add(new Agent(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), row[6].ToString(), row[7].ToString(), int.Parse(row[8].ToString()), int.Parse(row[9].ToString())));
            }
            return agents;
        }
        public void AddCallAgent(string fname, string lname, string uname, string password, int totalhours, string agentext, string avgcalllength, int totalcalls, int performancescore)
        {
            DataHandler dh = new DataHandler();
            dh.AddCallAgent(fname, lname, uname, password, totalhours, agentext, avgcalllength, totalcalls, performancescore);
        }
        public void UpdateCallAgent(int pidagent, string fname, string lname, string uname, string password, int totalhours, string agentext, string avgcalllength, int totalcalls, int performancescore)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteCallAgent(pidagent.ToString());
            dh.AddCallAgent(fname, lname, uname, password, totalhours, agentext, avgcalllength, totalcalls, performancescore);
        }
        public void DeleteCallAgent(string pidagent)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteCallAgent(pidagent);
        }
    }
}
