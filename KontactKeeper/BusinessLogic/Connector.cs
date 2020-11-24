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
        DataHandler dh = new DataHandler();
        ///////////////////////////////////////ADMINS/////////////////////////////////////////////////////////
        public List<Admin> GetAdmins()
        {
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
            dh.AddAdmin(fname, lname, uname, password);
        }

        public void UpdateAdmin(string pidadmin, string fname, string lname, string uname, string password)
        {
            dh.DeleteAdmin(pidadmin);
            dh.AddAdmin(fname, lname, uname, password);
        }

        public void DeleteAdmin(string pidadmin)
        {
            dh.DeleteAdmin(pidadmin);
        }

        public List<Admin> SearchAdmin(string fname = "", string lname = "", string uname = "")
        {
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
            DataTable dt = dh.Read("tblFBUser");
            List<FBUser> users = new List<FBUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new FBUser(row[1].ToString(), row[2].ToString(), SqlDateTime.Parse(row[3].ToString()), row[4].ToString()));
            }
            return users;
        }
        public void AddFBUser(string fbid, string name, SqlDateTime lastseen)
        {
            DateTime current = DateTime.Now;
            dh.AddFBUser(fbid, name, lastseen, current.ToString());
        }
        public void UpdateFBUser(string fbid, string name, SqlDateTime lastseen, string lastsent)
        {
            dh.DeleteFBUser(fbid);
            dh.AddFBUser(fbid, name, lastseen, lastsent);
        }

        public List<FBUser> SearchFBUser(string fbid = null,string name = null)
        {
            List<FBUser> users = new List<FBUser>();
            if (name != null)
            {
                DataTable dt = dh.SearchFBUser(name: name);
                foreach (DataRow row in dt.Rows)
                    users.Add(new FBUser(row[1].ToString(), row[2].ToString(), SqlDateTime.Parse(row[3].ToString()), row[4].ToString()));
            }
            if (fbid != null)
            {
                DataTable dt = dh.SearchFBUser(fbid: fbid);
                foreach (DataRow row in dt.Rows)
                    users.Add(new FBUser(row[1].ToString(), row[2].ToString(), SqlDateTime.Parse(row[3].ToString()) ,row[4].ToString()));
            }
            return users;
        }
        /////////////////////////////////////////WAUSERS////////////////////////////////////////////////////
        public List<WAUser> GetWAUsers()
        {
            DataTable dt = dh.Read("tblWAUser");
            List<WAUser> users = new List<WAUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new WAUser(row[1].ToString(), row[2].ToString(), row[3].ToString()));
            }
            return users;
        }
        public void AddWAUser(string phone, string lastseen, string lastsent)
        {
            dh.AddWAUser(phone, lastseen, lastsent);
        }
        public void UpdateWALastSeen(string phone, string lastseen, string lastsent)
        {
            dh.DeleteWAUser(phone);
            dh.AddWAUser(phone, lastseen, lastsent);
        }

        public List<WAUser> SearchWAUser(string phone = null)
        {
            List<WAUser> users = new List<WAUser>();
            if (phone != null)
            {
                DataTable dt = dh.SearchWAUser(phone: phone);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new WAUser(row[1].ToString(), row[2].ToString(), row[3].ToString()));
                }
            }
            return users;
        }
        //////////////////////////////////////////////////EMAILUSER//////////////////////////////
        public List<EmailUser> GetEmailUsers()
        {
            DataTable dt = dh.Read("tblEmailUser");
            List<EmailUser> users = new List<EmailUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new EmailUser(row[1].ToString(), row[2].ToString(), row[3].ToString()));
            }
            return users;
        }
        public void AddEmailUser(string email, string lastseen, string lastsent)
        {
            dh.AddEmailUser(email, lastseen, lastsent);
        }
        public void UpdateEmailLastSeen(string email, string lastseen, string lastsent)
        {
            dh.DeleteEmailUser(email);
            dh.AddEmailUser(email, lastseen, lastsent);
        }

        public List<EmailUser> SearchEmailUser(string email = null)
        {
            List<EmailUser> users = new List<EmailUser>();
            if (email != null)
            {
                DataTable dt = dh.SearchEmailUser(email: email);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EmailUser(row[1].ToString(), row[2].ToString(), row[2].ToString()));
                }
            }
            return users;
        }
        //////////////////////////////////////////////////ENDUSERS///////////////////////////////
        public List<EndUser> GetEndUsers()
        {
            DataTable dt = dh.Read("tblEndUser");
            List<EndUser> users = new List<EndUser>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
            }
            return users;
        }
        public void AddEndUser(string fname, string lname, string uname, string password, string cellnumber, string email, string fbid)
        {
            dh.AddEndUser(fname, lname, uname, password, cellnumber, email, fbid);

        }
        public void UpdateEndUser(string pidenduser, string fname, string lname, string uname, string password, string cellnumber, string email, string fbid)
        {
            dh.DeleteEndUser(pidenduser);
            dh.AddEndUser(fname, lname, uname, password, cellnumber, email, fbid);
        }
        public void DeleteEndUser(string pidenduser)
        {
            dh.DeleteEndUser(pidenduser);
        }

        public List<EndUser> SearchEndUsers(string fbid = null, string fname = null, string lname = null, string uname = null, string cellnumber = null, string email = null)
        {
            List<EndUser> users = new List<EndUser>();
            if (fbid != null)
            {
                DataTable dt = dh.SearchEndUser(fbid: fbid);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
                }
            }
            if (fname != null)
            {
                DataTable dt = dh.SearchEndUser(fname: fname);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
                }
            }
            if (lname != null)
            {
                DataTable dt = dh.SearchEndUser(lname: lname);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
                }
            }
            if (uname != null)
            {
                DataTable dt = dh.SearchEndUser(uname: uname);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
                }
            }
            if (cellnumber != null)
            {
                DataTable dt = dh.SearchEndUser(cellnumber: cellnumber);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
                }
            }
            if (email != null)
            {
                DataTable dt = dh.SearchEndUser(email: email);
                foreach (DataRow row in dt.Rows)
                {
                    users.Add(new EndUser(int.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()));
                }
            }
            return users;
        }
        /////////////////////////////////////////////CALLAGENTS///////////////////////////////////
        public List<Agent> GetCallAgents()
        {
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
            dh.AddCallAgent(fname, lname, uname, password, totalhours, agentext, avgcalllength, totalcalls, performancescore);
        }
        public void UpdateCallAgent(int pidagent, string fname, string lname, string uname, string password, int totalhours, string agentext, string avgcalllength, int totalcalls, int performancescore)
        {
            dh.DeleteCallAgent(pidagent.ToString());
            dh.AddCallAgent(fname, lname, uname, password, totalhours, agentext, avgcalllength, totalcalls, performancescore);
        }
        public void DeleteCallAgent(string pidagent)
        {
            dh.DeleteCallAgent(pidagent);
        }

        public List<Agent> SearchAgent(string fname=null, string lname = null, string uname = null, int totalhours=0, int totalcalls=0)
        {
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
