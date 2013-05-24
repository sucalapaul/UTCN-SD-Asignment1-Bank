using AutoMapper;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business
{
    public class ClientBiz
    {
        private Repository.Repository repository;

        public ClientBiz()
        {
            repository = new Repository.Repository();
            Mapper.CreateMap<Client, POCO.Client>();
            Mapper.CreateMap<POCO.Client, Client>();
        }

        public POCO.Client Search(string cnp)
        {
            Client client = repository.SearchClientByCnp(cnp);
            POCO.Client clientPoco = Mapper.Map<Client, POCO.Client>(client);

            return clientPoco;
        }

        public int Save(int clientId, string firstName, string lastName, string address, string cnp, string icn)
        {
            POCO.Client clientPoco = new POCO.Client(clientId, firstName, lastName, address, cnp, icn);
            Client client = Mapper.Map<POCO.Client, Client>(clientPoco);
            return repository.saveClient(client);
        }

        public bool Delete(int clientId)
        {
            return repository.deleteClientById(clientId);
        }
    }
}
