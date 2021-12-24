using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChildrenBookStore.Models;

namespace ChildrenBookStore.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Book> Book { get; set; }
        public DbSet<ChildrenBookStore.Models.usersaccounts> usersaccounts { get; set; }
        public DbSet<ChildrenBookStore.Models.orders> orders { get; set; }
        public DbSet<ChildrenBookStore.Models.report> report { get; set; }

    }
}
