using System.Collections.Generic;
using ToDo.API.Contracts;
using ToDo.API.Entities;
using System.Linq;

namespace ToDo.API.Repository
{
    public class AccountsRepository : IAccountsRepository
    {
        private RepositoryContext _repositoryContext { get; set; }
        public AccountsRepository(RepositoryContext context)
        {
            _repositoryContext = context;
        }
        IEnumerable<Account> IAccountsRepository.FindAll()
        {
            return _repositoryContext.Accounts.ToList();
        }

        void IAccountsRepository.Create(Account account)
        {
            _repositoryContext.Accounts.Add(account);
        }

        void IAccountsRepository.Update(Account account)
        {
            _repositoryContext.Accounts.Update(account);
        }

        void IAccountsRepository.Delete(Account account)
        {
            _repositoryContext.Accounts.Remove(account);
        }
    }
}