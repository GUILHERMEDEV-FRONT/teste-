using Microsoft.EntityFrameworkCore;

namespace dbcodefirst 
{
     public class AppDbContext : DbContext
     {
       

        public DbSet<Produtos> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Data Source=MACORATTI;" +
             "Initial Catalog=EFCoreDB;Integrated Security=True");
        }
    }
}