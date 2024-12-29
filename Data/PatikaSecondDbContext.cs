using CodeFirstRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Data
{
    public class PatikaSecondDbContext:DbContext
    {
        public DbSet<User>Users { get; set; }
        public DbSet<Post>Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = "server=(localdb)\\MSSQLLocalDB;database=PatikaCodeFirstDb2;trusted_connection=true";
            optionsBuilder.UseSqlServer(cs);
            base.OnConfiguring(optionsBuilder);
        }
       
    }
}
