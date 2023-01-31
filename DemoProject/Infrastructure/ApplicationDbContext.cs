using DemoDomain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=IamGoingToWorkInAmazon; User Id=postgres; Password=helpmegod1!");
        }

        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Category> Categories  => Set<Category>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Debt> Debts => Set<Debt>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductStore> ProductStores => Set<ProductStore>();
        public DbSet<Store> Stores => Set<Store>();
        public DbSet<Transaction> Transactions => Set<Transaction>();


    }
}
