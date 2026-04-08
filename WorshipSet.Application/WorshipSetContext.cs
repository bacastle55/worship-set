using Microsoft.EntityFrameworkCore;
using WorshipSet.Domain.Songs;

namespace WorshipSet.Application
{
    public class WorshipSetContext : DbContext
    {
        public WorshipSetContext(DbContextOptions<WorshipSetContext> options)
            : base(options) { }

        public DbSet<Song> Songs { get; set; }
    }
}
