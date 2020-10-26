using Microsoft.EntityFrameworkCore;

namespace ToDo.API.Entities
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base (options)
        { }

        internal DbSet<Account> Accounts { get; set; }
        internal DbSet<TodoItem> TodoItems { get; set; }
    }
}