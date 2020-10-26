using System.Collections.Generic;
using ToDo.API.Entities;

namespace ToDo.API.Contracts
{
    internal interface IAccountsRepository {
        IEnumerable<Account> FindAll();
        void Create(Account account);
        void Update(Account account);
        void Delete(Account account);

    }
}