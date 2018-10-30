using System.Data.Entity;
using MentalHealthTracker.Domain.Entities;

namespace MentalHealthTracker.Domain
{
    class MentalContext : DbContext
    {
        public DbSet<Entry> Students { get; set; }
        public DbSet<User> Addresses { get; set; }
    }
}
