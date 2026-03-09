using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },

                new IdentityRole
                {
                    Id = "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                    Name = "Operator",
                    NormalizedName = "OPERATOR"
                },

                new IdentityRole
                {
                    Id = "b305332b-ae64-4d7f-8aa2-ecb23ecb7c2a",
                    Name = "Human Resource",
                    NormalizedName = "RH"
                },

                new IdentityRole
                {
                    Id = "5e04cc88-efe0-4e53-bf10-7eb5463fb026",
                    Name = "Public Accountant",
                    NormalizedName = "PUBLIC ACCOUNTANT"
                }
            );
        }
    }
}

