using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	class EndUser
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
		private bool waverified;

		public bool WAVerified
		{
			get { return waverified; }
			set { waverified = value; }
		}
		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		private bool emailverified;

		public bool EmailVerified
		{
			get { return emailverified; }
			set { emailverified = value; }
		}
		private string fbid;

		public string FBID
		{
			get { return fbid; }
			set { fbid = value; }
		}

		private bool fbverified;

		public bool FBVerified
		{
			get { return fbverified; }
			set { fbverified = value; }
		}


		public EndUser(int pidenduser, string fname, string lname, string uname, string password, string cellnumber, bool waverified, string email, bool emailverified, string fbid, bool fbverified)
		{
			this.pidenduser = pidenduser;
			this.fname = fname;
			this.lname = lname;
			this.uname = uname;
			this.password = password;
			this.cellnumber = cellnumber;
			this.waverified = waverified;
			this.email = email;
			this.emailverified = emailverified;
			this.fbid = fbid;
			this.fbverified = fbverified;
		}
	}
}
