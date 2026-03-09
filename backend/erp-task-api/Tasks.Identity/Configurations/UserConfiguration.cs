using Employees.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                //new ApplicationUser
                //{
                //    Id = "f284b3fd-f2cf-476e-a9b6-6560689cc48c",
                //    Email = "admin@locahost.com",
                //    NormalizedEmail = "admin@locahost.com",
                //    Nombre = "Giancarlos",
                //    Apellidos = "Torres",
                //    UserName = "giankt24",
                //    NormalizedUserName = "giankt24",
                //    PasswordHash = hasher.HashPassword(null, "giank123"),
                //    EmailConfirmed = true,
                //},
                //new ApplicationUser
                //{
                //    Id = "294d249b-9b57-48c1-9689-11a91abb6447",
                //    Email = "deyla@locahost.com",
                //    NormalizedEmail = "deyla@locahost.com",
                //    Nombre = "Deyla",
                //    Apellidos = "Torres",
                //    UserName = "deyla",
                //    NormalizedUserName = "deyla",
                //    PasswordHash = hasher.HashPassword(null, "deyla123"),
                //    EmailConfirmed = true,
                //},

                //new ApplicationUser
                //{
                //    Id = "2d83683c-5094-4d63-ba8b-5adb8873ecb0",
                //    Email = "sofia@locahost.com",
                //    NormalizedEmail = "sofia@locahost.com",
                //    Nombre = "Sofia",
                //    Apellidos = "Torres",
                //    UserName = "sofia",
                //    NormalizedUserName = "sofia",
                //    PasswordHash = hasher.HashPassword(null, "sofia123"),
                //    EmailConfirmed = true,
                //},

                //new ApplicationUser
                //{
                //    Id = "39f027cd-5727-427a-bafc-54ae006952fb",
                //    Email = "nicky@locahost.com",
                //    NormalizedEmail = "nicky@locahost.com",
                //    Nombre = "Nicky",
                //    Apellidos = "nicky",
                //    UserName = "nicky",
                //    NormalizedUserName = "nicky",
                //    PasswordHash = hasher.HashPassword(null, "nicky123"),
                //    EmailConfirmed = true,
                //}

                new ApplicationUser
                {
                    Id = 75761411,
                    IdentityId = Guid.NewGuid(),
                    Nombre = "Giancarlos",
                    Apellidos = "Torres",
                    Email = "admin@locahost.com",
                    Phone = "51988876217",
                    DateOfBirth = new DateTime(1998,10,9),
                    Country = "Peru",
                    CreatedDate = DateTime.Now,
                    CreatedBy = "75761411",
                    LastModifiedDate = DateTime.Now,
                    LastModifiedBy = "75761411",
                    //UserName = "giankt24",
                    //NormalizedUserName = "giankt24",
                    //PasswordHash = hasher.HashPassword(null, "giank123"),
                    //EmailConfirmed = true,
                }
                //new ApplicationUser
                //{
                //    //Id = "294d249b-9b57-48c1-9689-11a91abb6447",
                //    Email = "deyla@locahost.com",
                //    //NormalizedEmail = "deyla@locahost.com",
                //    Nombre = "Deyla",
                //    Apellidos = "Torres",
                //    //UserName = "deyla",
                //    //NormalizedUserName = "deyla",
                //    //PasswordHash = hasher.HashPassword(null, "deyla123"),
                //    //EmailConfirmed = true,
                //},

                //new ApplicationUser
                //{
                //    //Id = "2d83683c-5094-4d63-ba8b-5adb8873ecb0",
                //    Email = "sofia@locahost.com",
                //    //NormalizedEmail = "sofia@locahost.com",
                //    Nombre = "Sofia",
                //    Apellidos = "Torres",
                //    //UserName = "sofia",
                //    //NormalizedUserName = "sofia",
                //    //PasswordHash = hasher.HashPassword(null, "sofia123"),
                //    //EmailConfirmed = true,
                //},

                //new ApplicationUser
                //{
                //    //Id = "39f027cd-5727-427a-bafc-54ae006952fb",
                //    Email = "nicky@locahost.com",
                //    //NormalizedEmail = "nicky@locahost.com",
                //    Nombre = "Nicky",
                //    Apellidos = "nicky",
                //    //UserName = "nicky",
                //    //NormalizedUserName = "nicky",
                //    //PasswordHash = hasher.HashPassword(null, "nicky123"),
                //    //EmailConfirmed = true,
                //}
            );


        }
    }
}

