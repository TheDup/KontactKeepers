using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class FBUser
    {
		private string fbid;

		public string FBID
		{
			get { return fbid; }
			set { fbid = value; }
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private SqlDateTime lastseen;

		public SqlDateTime LastSeen
		{
			get {
				return lastseen; 
			}
			set { lastseen = value; }
		}


		public FBUser(string id, string name, SqlDateTime lastseen)
		{
			this.fbid = id;
			this.name = name;
			this.lastseen = lastseen;
		}
	}
}
