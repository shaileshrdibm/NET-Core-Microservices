using Mango.Service.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mango.Service.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Coupons> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupons>().HasData(new Coupons
            {
                CouponCode = "01C",
                CouponId = 1,
                DiscountAmount = 10,
                MinAmount = 20,
            });

            modelBuilder.Entity<Coupons>().HasData(new Coupons
            {
                CouponCode = "02C",
                CouponId = 2,
                DiscountAmount = 40,
                MinAmount = 30,
            });
        }
    }
}
