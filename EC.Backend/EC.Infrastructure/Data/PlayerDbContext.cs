using EC.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EC.Infrastructure.Data
{
    public class PlayerDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
