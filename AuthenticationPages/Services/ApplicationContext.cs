using AuthenticationPages.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationPages.Services
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";
            
            var manager = new IdentityRole("manager");
            manager.NormalizedName = "manager";
            
            var agent = new IdentityRole("agent");
            agent.NormalizedName = "agent";
            
            var viewer = new IdentityRole("viewer");
            viewer.NormalizedName = "viewer";

            builder.Entity<IdentityRole>().HasData(admin, manager, agent, viewer);
        }
    }
}
