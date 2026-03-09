using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8",
                    UserId = "f284b3fd-f2cf-476e-a9b6-6560689cc48c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63",
                    UserId = "294d249b-9b57-48c1-9689-11a91abb6447"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "b305332b-ae64-4d7f-8aa2-ecb23ecb7c2a",
                    UserId = "2d83683c-5094-4d63-ba8b-5adb8873ecb0"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "5e04cc88-efe0-4e53-bf10-7eb5463fb026",
                    UserId = "39f027cd-5727-427a-bafc-54ae006952fb"
                }

            );
        }
    }
}

