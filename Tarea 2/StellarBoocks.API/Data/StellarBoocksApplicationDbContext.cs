using Microsoft.EntityFrameworkCore;
using StelarsBooks.API.Entities;

namespace StellarBoocks.API.Data
{
    public class StellarBocksApplicationDbContext : DbContext
    {
        public StellarBocksApplicationDbContext(DbContextOptions<StellarBocksApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
