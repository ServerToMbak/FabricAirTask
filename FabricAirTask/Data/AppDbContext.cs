using FabricAirTask.Entity;
using Microsoft.EntityFrameworkCore;

namespace FabricAirTask.Data
{
    public class AppDbContext :DbContext
    {
  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=CANDIDATE_USER;Password=SH0W_YOUR_SK!LSS;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=rbsf.w.dedikuoti.lt)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)))");
        }
        public DbSet<Entity.File> Files { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
