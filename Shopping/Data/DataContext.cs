using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping.Entites;

namespace Shopping.Data
{
    public class DataContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid,
        IdentityUserClaim<Guid>, IdentityUserRole<Guid>, IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrdersDetails { get; set; } = null!;
        public DbSet<AppUser> AppUsers { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<ChoiceCategory> ChoiceCategories { get; set; } = null!;
        public DbSet<Choice> Choices { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductChoice> ProductChoices { get; set; } = null!;
        public DbSet<ProductInformation> ProductInformation { get; set; } = null!;

    }
}
