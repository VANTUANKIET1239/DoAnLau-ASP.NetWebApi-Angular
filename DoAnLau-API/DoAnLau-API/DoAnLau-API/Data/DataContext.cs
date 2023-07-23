using DoAnLau_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace DoAnLau_API.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
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

        public DbSet<PromotionDetail> PromotionDetails { get; set; }

        public DbSet<PromotionDetailPromotion> PromotionDetailPromotions { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Ward> Wards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Order_Detail>()
            .HasOne(a => a.order)
            .WithOne(a => a.order_Detail)
            .HasForeignKey<Order_Detail>(c => c.order_Id);


            modelBuilder.Entity<Order_Detail>()
          .HasKey(m => new { m.order_Id, m.orderDetail_Id });

            modelBuilder.Entity<PromotionDetailPromotion>()
        .HasKey(m => new { m.promotion_Id, m.promotionDetail_Id });


            modelBuilder.Entity<PromotionDetailPromotion>()
                .HasOne(pc => pc.promotion)
                .WithMany(c => c.promotionDetailPromotions)
                .HasForeignKey(c => c.promotionDetail_Id);

            modelBuilder.Entity<PromotionDetailPromotion>()
                    .HasOne(pc => pc.promotionDetail)
                    .WithMany(c => c.promotionDetailPromotions)
                    .HasForeignKey(c => c.promotion_Id);



            modelBuilder.Entity<BranchReservationTime>()
        .HasKey(m => new { m.branch_Id, m.reservationTime_Id });


            modelBuilder.Entity<BranchReservationTime>()
                .HasOne(pc => pc.branch)
                .WithMany(c => c.branchReservationTimes)
                .HasForeignKey(c => c.reservationTime_Id);

            modelBuilder.Entity<BranchReservationTime>()
                    .HasOne(pc => pc.reservationTime)
                    .WithMany(c => c.branchReservationTimes)
                    .HasForeignKey(c => c.branch_Id);


            modelBuilder.Entity<PromotionBranch>()
                .HasKey(pc => new { pc.promotion_Id, pc.branch_Id });

            modelBuilder.Entity<PromotionBranch>()
                .HasOne(pc => pc.promotion)
                .WithMany(c => c.promotionBranches)
                .HasForeignKey(c => c.branch_Id);

            modelBuilder.Entity<PromotionBranch>()
                    .HasOne(pc => pc.branch)
                    .WithMany(c => c.promotionBranches)
                    .HasForeignKey(c => c.promotion_Id);



            modelBuilder.Entity<PromotionUser>()
               .HasKey(pc => new { pc.promotion_Id, pc.user_Id });

            modelBuilder.Entity<PromotionUser>()
                .HasOne(pc => pc.user)
                .WithMany(c => c.promotionUsers)
                .HasForeignKey(c => c.promotion_Id);

            modelBuilder.Entity<PromotionUser>()
                    .HasOne(pc => pc.promotion)
                    .WithMany(c => c.promotionUsers)
                    .HasForeignKey(c => c.user_Id);




            modelBuilder.Entity<ReservationUser>()
              .HasKey(pc => new { pc.reservation_Id, pc.user_Id });

            modelBuilder.Entity<ReservationUser>()
                .HasOne(pc => pc.user)
                .WithMany(c => c.reservationUsers)
                .HasForeignKey(c => c.reservation_Id);

            modelBuilder.Entity<ReservationUser>()
                    .HasOne(pc => pc.reservation)
                    .WithMany(c => c.reservationUsers)
                    .HasForeignKey(c => c.user_Id);
        }
    }
}
