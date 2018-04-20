using EC.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Infrastructure.Data
{
    public class ECDbContext : DbContext
    {
        public ECDbContext(DbContextOptions<ECDbContext> options) : base(options) { }
        public DbSet<Event> Events { get; set; }

        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasMany(e => e.Players);
        }
    }
}
