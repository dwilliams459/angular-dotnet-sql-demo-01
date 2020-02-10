using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace timeline_server_dotnet.data

{
    public class timelineDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public timelineDbContext(DbContextOptions<timelineDbContext> options) : base(options)
        {
        }

    }
}
