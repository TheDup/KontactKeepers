using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class WAUser
    {
        private string cellnumber;

        public string CellNumber
        {
            get { return cellnumber; }
            set { cellnumber = value; }
        }
        private string lastseen;

        public string LastSeen
        {
            get { return lastseen; }
            set { lastseen = value; }
        }
        private string lastsent;

        public string LastSent
        {
            get { return lastsent; }
            set { lastsent = value; }
        }

        public WAUser(string cellnumber, string lastseen, string lastsent)
        {
            this.cellnumber = cellnumber;
            this.lastseen = lastseen;
            this.lastsent = lastsent;
        }
    }
}
