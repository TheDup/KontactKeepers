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

        public List<Admin> SearchAdmin(string fname = "", string lname = "", string uname = "")
        {
            DataHandler dh = new DataHandler();
            List<Admin> admins = new List<Admin>();
            if (uname!="")
            {
                DataTable dt = dh.SearchAdmin(uname: uname);
                foreach (DataRow row in dt.Rows)
                    admins.Add(new Admin(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            if (fname != "")
            {
                DataTable dt = dh.SearchAdmin(fname: fname);
                foreach (DataRow row in dt.Rows)
                    admins.Add(new Admin(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            if (lname != "")
            {
                DataTable dt = dh.SearchAdmin(lname: lname);
                foreach (DataRow row in dt.Rows)
                    admins.Add(new Admin(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()));
            }
            return admins;
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

        public List<FBUser> SearchFBUser(string fbid = null,string name = null)
        {
            DataHandler dh = new DataHandler();
            List<FBUser> users = new List<FBUser>();
            if (name != null)
            {
                DataTable dt = dh.SearchFBUser(name: name);
                foreach (DataRow row in dt.Rows)
                    users.Add(new FBUser(row[1].ToString(), row[2].ToString(), SqlDateTime.Parse(row[3].ToString())));
            }
            if (fbid != null)
            {
                DataTable dt = dh.SearchFBUser(fbid: fbid);
                foreach (DataRow row in dt.Rows)
                    users.Add(new FBUser(row[1].ToString(), row[2].ToString(), SqlDateTime.Parse(row[3].ToString())));
            }
            return users;
        }
        /////////////////////////////////////////WAUSERS////////////////////////////////////////////////////
        public List<WAUser> GetWAUsers()
        {
            DataHandler dh = new DataHandler();
            DataTable dt = dh.Read("tblWAUsers");
            List<WAUser> users = new List<WAUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new WAUser(row[1].ToString(), SqlDateTime.Parse(row[2].ToString())));
            }
            return users;
        }
        public void AddWAUser(string phone, SqlDateTime lastseen)
        {
            DataHandler dh = new DataHandler();
            dh.AddWAUser(phone, lastseen);
        }
        public void UpdateWALastSeen(string phone, SqlDateTime lastseen)
        {
            DataHandler dh = new DataHandler();
            dh.DeleteWAUser(phone);
            dh.AddWAUser(phone, lastseen);
        }

        public List<WAUser> SearchWAUser(string phone = null)
        {
            DataHandler dh = new DataHandler();
            List<WAUser> users = new List<WAUser>();
            if (phone != null)
            {
                DataTable dt = dh.SearchWAUser(phone: phone);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new WAUser(row[1].ToString(), SqlDateTime.Parse(row[2].ToString())));
                }
            }
            return users;
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

        public List<EndUser> SearchEndUsers(string fbid = null, string fname = null, string lname = null, string uname = null, string cellnumber = null, string email = null)
        {
            DataHandler dh = new DataHandler();
            List<EndUser> users = new List<EndUser>();
            if (fbid != null)
            {
                DataTable dt = dh.SearchEndUser(fbid: fbid);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
                }
            }
            if (fname != null)
            {
                DataTable dt = dh.SearchEndUser(fname: fname);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
                }
            }
            if (lname != null)
            {
                DataTable dt = dh.SearchEndUser(lname: lname);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
                }
            }
            if (uname != null)
            {
                DataTable dt = dh.SearchEndUser(uname: uname);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
                }
            }
            if (cellnumber != null)
            {
                DataTable dt = dh.SearchEndUser(cellnumber: cellnumber);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
                }
            }
            if (email != null)
            {
                DataTable dt = dh.SearchEndUser(email: email);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), bool.Parse(row[6].ToString()), row[7].ToString(), bool.Parse(row[8].ToString()), row[9].ToString(), bool.Parse(row[10].ToString())));
                }
            }
            return users;
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

        public List<Agent> SearchAgent(string fname=null, string lname = null, string uname = null, int totalhours=0, int totalcalls=0)
        {
            DataHandler dh = new DataHandler();
            List<Agent> agents = new List<Agent>();
            if (fname != null)
            {
                DataTable dt = dh.SearchCallAgent(fname: fname);
                foreach (DataRow row in dt.Rows)
                {
                    agents.Add(new Agent(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), row[6].ToString(), row[7].ToString(), int.Parse(row[8].ToString()), int.Parse(row[9].ToString())));
                }
            }
            if (lname != null)
            {
                DataTable dt = dh.SearchCallAgent(lname: lname);
                foreach (DataRow row in dt.Rows)
                {
                    agents.Add(new Agent(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), row[6].ToString(), row[7].ToString(), int.Parse(row[8].ToString()), int.Parse(row[9].ToString())));
                }
            }
            if (uname != null)
            {
                DataTable dt = dh.SearchCallAgent(uname: uname);
                foreach (DataRow row in dt.Rows)
                {
                    agents.Add(new Agent(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), row[6].ToString(), row[7].ToString(), int.Parse(row[8].ToString()), int.Parse(row[9].ToString())));
                }
            }
            if (totalhours != 0)
            {
                DataTable dt = dh.SearchCallAgent(totalHours: totalhours);
                foreach (DataRow row in dt.Rows)
                {
                    agents.Add(new Agent(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), row[6].ToString(), row[7].ToString(), int.Parse(row[8].ToString()), int.Parse(row[9].ToString())));
                }
            }
            if (totalcalls != 0)
            {
                DataTable dt = dh.SearchCallAgent(totalCalls: totalcalls);
                foreach (DataRow row in dt.Rows)
                {
                    agents.Add(new Agent(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), int.Parse(row[5].ToString()), row[6].ToString(), row[7].ToString(), int.Parse(row[8].ToString()), int.Parse(row[9].ToString())));
                }
            }
            return agents;
        }
    }
}
