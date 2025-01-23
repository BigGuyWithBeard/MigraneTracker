using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BigGuyWithBeard.MigraneTracker.MVC.Models;

namespace BigGuyWithBeard.MigraneTracker.MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BigGuyWithBeard.MigraneTracker.MVC.Models.Observation> Observations { get; set; } = default!;
    }
}
