using Microsoft.EntityFrameworkCore;
using MyWeb.api.Models.Domain;

namespace MyWeb.api.Data
{
    public class MyWebDbContext: DbContext
    {
        public MyWebDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties {  get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
