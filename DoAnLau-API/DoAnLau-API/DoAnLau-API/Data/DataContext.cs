using DoAnLau_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace DoAnLau_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<City> Cities { get; set; }


        public DbSet<District> Districts { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Order_Detail> Order_Details { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<PromotionBranch> PromotionBranchs { get; set; }

        public DbSet<PromotionUser> PromotionUsers { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<ReservationUser> ReservationUsers { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Ward> Wards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Order_Detail>()
            .HasOne(a => a.Order)
            .WithOne(a => a.Order_Detail)
            .HasForeignKey<Order_Detail>(c => c.Order_Id);


            modelBuilder.Entity<Order_Detail>()
          .HasKey(m => new { m.Order_Id, m.OrderDetail_Id });

            modelBuilder.Entity<PromotionBranch>()
                .HasKey(pc => new { pc.Promotion_Id, pc.Branch_Id });

            modelBuilder.Entity<PromotionBranch>()
                .HasOne(pc => pc.Promotion)
                .WithMany(c => c.PromotionBranches)
                .HasForeignKey(c => c.Branch_Id);

            modelBuilder.Entity<PromotionBranch>()
                    .HasOne(pc => pc.Branch)
                    .WithMany(c => c.PromotionBranches)
                    .HasForeignKey(c => c.Promotion_Id);



            modelBuilder.Entity<PromotionUser>()
               .HasKey(pc => new { pc.Promotion_Id, pc.User_Id });

            modelBuilder.Entity<PromotionUser>()
                .HasOne(pc => pc.User)
                .WithMany(c => c.PromotionUsers)
                .HasForeignKey(c => c.Promotion_Id);

            modelBuilder.Entity<PromotionUser>()
                    .HasOne(pc => pc.Promotion)
                    .WithMany(c => c.PromotionUsers)
                    .HasForeignKey(c => c.User_Id);




            modelBuilder.Entity<ReservationUser>()
              .HasKey(pc => new { pc.Reservation_Id, pc.User_Id });

            modelBuilder.Entity<ReservationUser>()
                .HasOne(pc => pc.User)
                .WithMany(c => c.ReservationUsers)
                .HasForeignKey(c => c.Reservation_Id);

            modelBuilder.Entity<ReservationUser>()
                    .HasOne(pc => pc.Reservation)
                    .WithMany(c => c.ReservationUsers)
                    .HasForeignKey(c => c.User_Id);
        }
    }
}
