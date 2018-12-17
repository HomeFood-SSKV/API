using Microsoft.EntityFrameworkCore;
using DotnetCore.Business.Entities;
using WebApi.Common;

namespace Chinook.Data
{
    public class HomeFoodEntities : DbContext
    {

        public HomeFoodEntities()
        {

        }
        public DbSet<MAS_AddressType> MAS_AddressType { get; set; }
        public DbSet<MAS_Area> MAS_Area { get; set; }
        public DbSet<MAS_Category> MAS_Category { get; set; }
        public DbSet<MAS_ChefType> MAS_ChefType { get; set; }
        public DbSet<MAS_City> MAS_City { get; set; }
        public DbSet<MAS_DeliveryLocation> MAS_DeliveryLocation { get; set; }
        public DbSet<MAS_Discount> MAS_Discount { get; set; }
        public DbSet<MAS_DiscountType> MAS_DiscountType { get; set; }
        public DbSet<MAS_Food> MAS_Food { get; set; }
        public DbSet<MAS_FoodType> MAS_FoodType { get; set; }
        public DbSet<MAS_MealPack> MAS_MealPack { get; set; }
        public DbSet<MAS_OrderStatus> MAS_OrderStatus { get; set; }
        public DbSet<MAS_OrderType> MAS_OrderType { get; set; }
        public DbSet<MAS_PaymentType> MAS_PaymentType { get; set; }
        public DbSet<MAS_Price> MAS_Price { get; set; }
        public DbSet<MAS_Rights> MAS_Rights { get; set; }
        public DbSet<MAS_Role> MAS_Role { get; set; }
        public DbSet<Observe> Observe { get; set; }
        public DbSet<TRN_ChefDetails> TRN_ChefDetails { get; set; }
        public DbSet<TRN_ChefOrder> TRN_ChefOrder { get; set; }
        public DbSet<TRN_ChefOtherDetails> TRN_ChefOtherDetails { get; set; }
        public DbSet<TRN_DeliveryDetails> TRN_DeliveryDetails { get; set; }
        public DbSet<TRN_GroupRights> TRN_GroupRights { get; set; }
        public DbSet<TRN_MapOrderToChef> TRN_MapOrderToChef { get; set; }
        public DbSet<TRN_MealPackMapping> TRN_MealPackMapping { get; set; }
        public DbSet<TRN_MealPackProcessing> TRN_MealPackProcessing { get; set; }
        public DbSet<TRN_Order> TRN_Order { get; set; }
        public DbSet<TRN_OrderAppliedDiscount> TRN_OrderAppliedDiscount { get; set; }
        public DbSet<TRN_OrderDetails> TRN_OrderDetails { get; set; }
        public DbSet<TRN_SpecialDiscount> TRN_SpecialDiscount { get; set; }
        public DbSet<TRN_UserAddressDetails> TRN_UserAddressDetails { get; set; }
        public DbSet<TRN_UserDetail> TRN_UserDetail { get; set; }
        public DbSet<TRN_UserPassword> TRN_UserPassword { get; set; }
        public DbSet<TRN_UserRights> TRN_UserRights { get; set; }
        private static string _dbName = AppSettings.ConnectionStrings;

        public HomeFoodEntities(DbContextOptions<HomeFoodEntities> options) : base(options)
        {

        }

        public HomeFoodEntities(string dbName)
        {
            _dbName = AppSettings.ConnectionStrings;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!string.IsNullOrEmpty(_dbName))
                optionsBuilder.UseSqlServer(_dbName);
        }

    }
}