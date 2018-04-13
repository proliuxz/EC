using EC.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EC.Infrastructure.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
