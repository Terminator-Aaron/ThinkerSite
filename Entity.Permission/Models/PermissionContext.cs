using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Entity.Permission.Models.Mapping;

namespace Entity.Permission.Models
{
    public partial class PermissionContext : DbContext
    {
        static PermissionContext()
        {
            Database.SetInitializer<PermissionContext>(null);
        }

        public PermissionContext()
            : base("Name=PermissionContext")
        {
        }

        public DbSet<dtStatu> dtStatus { get; set; }
        public DbSet<dtSysDict> dtSysDicts { get; set; }
        public DbSet<dtSystem> dtSystems { get; set; }
        public DbSet<dtUser> dtUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new dtStatuMap());
            modelBuilder.Configurations.Add(new dtSysDictMap());
            modelBuilder.Configurations.Add(new dtSystemMap());
            modelBuilder.Configurations.Add(new dtUserMap());
        }
    }
}
