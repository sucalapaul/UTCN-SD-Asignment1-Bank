using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Repository
{
    public class Repository
    {
        public Repository()
        {
            Entities = new DB_A1_BANKEntities();
            Mapper.CreateMap<Client, Client>();
        }


        protected DB_A1_BANKEntities Entities
        {
            get;
            private set;
        }



        public User getUserByUsername(string username)
        {
            return (from u in Entities.Users
                    where u.Username == username
                    select u).FirstOrDefault();
        }



        public Client SearchClientByCnp(string cnp)
        {
            return (from c in Entities.Clients
                    where c.CNP == cnp
                    select c).FirstOrDefault();
        }

        public int saveClient(Client client)
        {
            Client dbClient = (from c in Entities.Clients
                        where c.ID == client.ID
                        select c).FirstOrDefault();

            if (dbClient == null)
            {
                Entities.Clients.Add(client);
                Entities.SaveChanges();
                return client.ID;
            }
            else
            {
                dbClient.FirstName = client.FirstName;
                dbClient.LastName = client.LastName;
                dbClient.Address = client.Address;
                dbClient.CNP = client.CNP;
                dbClient.ICN = client.ICN;

                Entities.SaveChanges();
                return dbClient.ID;
            }
        }

        public bool deleteClientById(int clientId)
        {
            Client client = (from c in Entities.Clients
                                 where c.ID == clientId
                                 select c).FirstOrDefault();
            if (client != null)
            {
                Entities.Clients.Remove(client);
                Entities.SaveChanges();
                return true;
            }
            return false;
        }

        public int saveAccount(Account a)
        {
            Entities.Accounts.Add(a);
            Entities.SaveChanges();
            return a.ID;
        }

        public Client GetClientById(int clientId)
        {
            return (from c in Entities.Clients
                    where c.ID == clientId
                    select c).FirstOrDefault();
        }
    }
}
