using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Database
{
    public class MyEFContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;" +
                "Port=5432;" +
                "Database=hellotest;" +
                "Username=postgres;" +
                "Password=123456");
        }
    }
}
