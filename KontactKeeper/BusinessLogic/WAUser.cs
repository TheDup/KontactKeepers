using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class WAUser
    {
        private string cellnumber;

        public string CellNumber
        {
            get { return cellnumber; }
            set { cellnumber = value; }
        }
        private SqlDateTime lastseen;

        public SqlDateTime LastSeen
        {
            get { return lastseen; }
            set { lastseen = value; }
        }

        public WAUser(string cellnumber, SqlDateTime lastseen)
        {
            this.cellnumber = cellnumber;
            this.lastseen = lastseen;
        }
    }
}
