﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace BusinessLogic
{
    public class EmailUser
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
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

        public EmailUser(string email, string lastseen, string lastsent)
        {
            this.email = email;
            this.lastseen = lastseen;
            this.lastsent = lastsent;
        }
    }
}
