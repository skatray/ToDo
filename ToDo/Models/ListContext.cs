using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ToDo.Models
{
    public class ListContext : DbContext
    {

        public DbSet<List> Lists { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ListContext(DbContextOptions<ListContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }       
    }
}
