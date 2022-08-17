using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Plantbook.Models;

namespace Plantbook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<PlantPosting> PlantPostings { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}