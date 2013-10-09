using System.Data.Entity;

namespace EntityFrameworkTest
{
    class ProductDb2 : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
