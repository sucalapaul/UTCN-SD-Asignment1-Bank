using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Repository;
using AutoMapper;

namespace Bank.Business
{
    public class LoginBiz
    {
        Bank.Repository.Repository repository;

        public LoginBiz()
        {
            repository = new Repository.Repository();
        }

        public int getUserType(string username, string password)
        {
            Mapper.CreateMap<User, POCO.User>();
            User user = repository.getUserByUsername(username);
            POCO.User userPoco = Mapper.Map<POCO.User>(user);

            if (user == null)
            {
                return -1;
            }

            if (user.Password != password)
            {
                return -1;
            }
            return user.Type;
        }
    }
}
