using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public class EndUser
	{
		private int pidenduser;

		public int PIDEndUser
		{
			get { return pidenduser; }
			set { pidenduser = value; }
		}

		private string fname;

		public string FName
		{
			get { return fname; }
			set { fname = value; }
		}
		private string lname;

		public string LName
		{
			get { return lname; }
			set { lname = value; }
		}
		private string uname;

		public string UName
		{
			get { return uname; }
			set { uname = value; }
		}
		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}
		private string cellnumber;

		public string CellNumber
		{
			get { return cellnumber; }
			set { cellnumber = value; }
		}
		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		private string fbid;

		public string FBID
		{
			get { return fbid; }
			set { fbid = value; }
		}

		public EndUser(int pidenduser, string fname, string lname, string uname, string password, string cellnumber,  string email,  string fbid)
		{
			this.pidenduser = pidenduser;
			this.fname = fname;
			this.lname = lname;
			this.uname = uname;
			this.password = password;
			this.cellnumber = cellnumber;
			this.email = email;
			this.fbid = fbid;
		}
	}
}
