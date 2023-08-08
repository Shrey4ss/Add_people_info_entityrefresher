using Add_people_info_entityrefresher.Models;
using Microsoft.EntityFrameworkCore;

namespace Add_people_info_entityrefresher.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
            
        }
        public DbSet<People>Peoples { get; set; }
    }
}
