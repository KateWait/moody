using Models;
using System.Data.Entity;

namespace Moody.Context
{
    public class MoodyContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
    }
}