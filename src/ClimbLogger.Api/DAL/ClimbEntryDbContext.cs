using ClimbLogger.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ClimbLogger.Api.DAL
{
    public class ClimbEntryDbContext : DbContext
    {
        public DbSet<ClimbEntry> ClimbEntries { get; set; }

        public ClimbEntryDbContext()
        {
            
        }

        public ClimbEntryDbContext(DbContextOptions<ClimbEntryDbContext> options) : base(options)
        {
            
        }
    }
}