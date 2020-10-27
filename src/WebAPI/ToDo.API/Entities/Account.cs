using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDo.API.Entities
{
    internal class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<TodoItem> TodoItems { get; set; }
    }
}