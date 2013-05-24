using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Repository;
using AutoMapper;

namespace Bank.Business
{
    public class AccountBiz
    {
        private Repository.Repository repository;
        public AccountBiz()
        {
            repository = new Repository.Repository();
            Mapper.CreateMap<Client, POCO.Client>();
            Mapper.CreateMap<POCO.Client, Client>();
            Mapper.CreateMap<Account, POCO.Account>();
            Mapper.CreateMap<POCO.Account, Account>();
        }

        public POCO.Client Search(string cnp)
        {
            Client client = repository.SearchClientByCnp(cnp);
            POCO.Client clientPoco = Mapper.Map<Client, POCO.Client>(client);

            return clientPoco;
        }



        public int Save(POCO.Account account)
        {
            Account a = Mapper.Map<POCO.Account, Account>(account);
            return repository.saveAccount(a);
        }

        public POCO.Client Get(int clientId)
        {
            Client client = repository.GetClientById(clientId);
            POCO.Client clientPoco = Mapper.Map<Client, POCO.Client>(client);

            return clientPoco;
        }
    }
}
