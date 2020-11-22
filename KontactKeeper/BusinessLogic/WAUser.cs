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

        public WAUser(string cellnumber, string lastseen)
        {
            this.cellnumber = cellnumber;
            this.lastseen = lastseen;
        }
    }
}
