using Cafe.Entities.Code;
using System.Data.Entity;

namespace Cafe.AppContext.Code
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Composition> Compositions { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderFromMenu> OrderFromMenues { get; set; }
        public DbSet<Purchaser> Purchasers { get; set; }
        public DbSet<Steward> Stewards { get; set; }
        public DbSet<Supple> Suppliers { get; set; }

        public MyAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        static MyAppDbContext()
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
        }
    }
}
