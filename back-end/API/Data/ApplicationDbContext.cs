using API.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Workstation> Workstations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<IdentityRole<Guid>>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Workstation)
                .WithMany()
                .HasForeignKey(d => d.WorkstationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Deal>()
                .HasOne(d => d.Customer)
                .WithMany()
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<UserWorkstation>()
                .HasKey(uw => new { uw.UserId, uw.WorkstationId });

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Workstation)
                .WithMany(w => w.Transactions)
                .HasForeignKey(t => t.WorkstationId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Workstation)
                .WithMany()
                .HasForeignKey(r => r.WorkstationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany()
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany()
                .HasForeignKey(r => r.RoomId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.CreatedBy)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
