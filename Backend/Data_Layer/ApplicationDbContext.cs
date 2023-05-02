using Microsoft.EntityFrameworkCore;
using Shared_Layer;
using System.Collections.Generic;

namespace Data_Layer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Shared_Layer.Product> Product { get; set; } = default!;
    }
}