using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.POCO
{
    public class Client
    {
        public Client() { }

        public Client(int clientId, string firstName, string lastName, string address, string cnp, string icn)
        {
            // TODO: Complete member initialization
            this.ID = clientId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.CNP = cnp;
            this.ICN = icn;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CNP { get; set; }
        public string ICN { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
