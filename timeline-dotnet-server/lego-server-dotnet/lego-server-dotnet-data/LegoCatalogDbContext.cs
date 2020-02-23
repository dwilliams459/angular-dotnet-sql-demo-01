using lego_server_dotnet_domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lego_server_dotnet_data
{
    public class LegoCatalogDbContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<PartColor> PartColors { get; set; }

    }
}
