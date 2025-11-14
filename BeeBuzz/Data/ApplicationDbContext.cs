using BeeBuzz.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           //options.HasMany(e => e.Roles).WithOne().HasForeignKey("RoleId").isReuired();


        }

        public DbSet<Organization> Products { get; set; }
        public DbSet<Beehive> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Beehive>().Property(o => o.GetType)
            //    .HasColumnType("location");

            modelBuilder.Entity<Organization>()
               .Property(o => o.uniqID)
               .HasColumnType("OrganizationID");

            modelBuilder.Entity<Beehive>()
                .Property(o => o.location)
                .HasColumnType("Location");

            modelBuilder.Entity<Beehive>()
                .Property(o => o.status)
                .HasColumnType("Satus");

            modelBuilder.Entity<Beehive>()
                .Property(o => o.deactivationReason)
                .HasColumnType("DeactivationReason");

        }
    }
}
