using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace FabricAirTask.Data
{
    public class AppDbContext :DbContext
    {
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseOracle("Connection string will be here");
                Console.WriteLine("Connected");
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
           
        }
        public DbSet<Entity.File> Files { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
