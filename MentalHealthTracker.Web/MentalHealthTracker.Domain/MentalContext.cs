using System.Data.Entity;
using MentalHealthTracker.Domain.Entities;

namespace MentalHealthTracker.Domain
{
    public class MentalContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
