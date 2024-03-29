﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.POCO
{
    public class User
    {
        public User()
        { 
        
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
