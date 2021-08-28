using Microsoft.EntityFrameworkCore;
using SharedAssemblies2.Models;

namespace basicblazorexamplewebapp.DBRepo
{
    public class MasterDBContext : DbContext
    {
        public MasterDBContext()
        {
        }
        
        public DbSet<Name> Names { get; set; }

        public MasterDBContext(DbContextOptions<MasterDBContext> options)
            : base(options)
        {
            
        }
    }
}