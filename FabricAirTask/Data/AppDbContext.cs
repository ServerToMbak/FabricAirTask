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
                optionsBuilder.UseOracle("User Id=CANDIDATE_USER;Password=SH0W_YOUR_SK!LSS;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=rbsf.w.dedikuoti.lt)(PORT=1521))(CONNECT_DATA=(SID=XE)))");
                Console.WriteLine("Connected");
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
           
        }
        public DbSet<Entity.File> Files { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
