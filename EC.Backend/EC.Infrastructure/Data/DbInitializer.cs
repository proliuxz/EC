using System;
using System.Linq;

namespace EC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ECDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            // Look for any students.
            if (dbContext.Events.Any() && dbContext.Players.Any())
            {
                return;   // DB has been seeded
            }
        }
    }
}