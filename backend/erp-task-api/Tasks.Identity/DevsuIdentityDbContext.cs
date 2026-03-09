using CleanArchitecture.Identity.Configurations;
using Employees.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Employees.Identity
{
    public class DevsuIdentityDbContext : IdentityDbContext
    {
        public DevsuIdentityDbContext(DbContextOptions<DevsuIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.ApplyConfiguration(new RoleConfiguration());
            //builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new UserRoleConfiguration());
        }

        public virtual DbSet<RefreshToken>? RefreshTokens { get; set; }
        public virtual DbSet<ApplicationUser>? ApplicationUsers { get; set; }

    }
}

