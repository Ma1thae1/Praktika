using Praktika.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Praktika.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Investment> Investments { get; set; }
    }
}
