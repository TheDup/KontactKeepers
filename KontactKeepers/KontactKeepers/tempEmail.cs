using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontactKeepers
{
    class tempEmail
    {
		private string emailaddress;

		public string EmailAddress
		{
			get { return emailaddress; }
			set { emailaddress = value; }
		}

		public tempEmail(string emailaddress)
		{
			this.emailaddress = emailaddress;
		}
	}
}
