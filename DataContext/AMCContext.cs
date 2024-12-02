using AMCMANAGMENT.Model;
using Microsoft.EntityFrameworkCore;

namespace AMCMANAGMENT.DataContext
{
    public class AMCContext : DbContext
    {
        public AMCContext(DbContextOptions<AMCContext> options) : base(options) { }

        public DbSet<AssetCategory> AssetCategory { get; set; }
        public DbSet<Asset> assets { get; set; }
        public DbSet<AMC> aMCs { get; set; }
        public DbSet<AMCTeam> aMCTeams { get; set; }
        public DbSet<AMCTeamDetails> aMCTeamDetails { get; set; }
        public DbSet<AMCType> aMCTypes { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<MaintainenceTask> maintenanceTasks { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Vehicle> vehicles { get; set; }
    }
}
