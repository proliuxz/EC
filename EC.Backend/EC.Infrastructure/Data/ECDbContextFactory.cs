using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EC.Infrastructure.Data
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<ECDbContext>
    {
        public ECDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ECDbContext>();
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EC;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new ECDbContext(optionsBuilder.Options);
        }
    }
}