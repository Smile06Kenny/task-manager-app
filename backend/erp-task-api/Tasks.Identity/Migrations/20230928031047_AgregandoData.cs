using Employees.Application.Models;
using Employees.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Diagnostics.Metrics;

#nullable disable

namespace Employees.Identity.Migrations
{
    public partial class AgregandoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8", "af66e885-a884-4487-8cf1-193bb3d7246b", "Administrator", "ADMINISTRATOR" },
                    { "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63", "476abfdf-9007-429e-ad9c-41e5e464f13c", "Operator", "OPERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b305332b-ae64-4d7f-8aa2-ecb23ecb7c2a", "cff5a97f-19fa-4428-a49c-500efad5754c", "Human Resource", "RH" },
                    { "5e04cc88-efe0-4e53-bf10-7eb5463fb026", "826102bc-197b-4ccd-bf4d-8ccfeb108e5f", "Public Accountant", "PUBLIC ACCOUNTANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "294d249b-9b57-48c1-9689-11a91abb6447", 0, "24f6e7bf-1fb8-471a-a80c-9a5548c7ac37", "deyla@locahost.com", true, false, null, "deyla@locahost.com", "deyla", hasher.HashPassword(null, "deyla123"), "51988876217", true, "4bdfd5da-f264-493c-b718-662ab0415459", false, "deyla" },
                    { "f284b3fd-f2cf-476e-a9b6-6560689cc48c", 0, "0e53003f-72cd-44ef-a53c-19a30ed0aa15", "giankt24@locahost.com", true, false, null, "giankt24@locahost.com", "giankt24", hasher.HashPassword(null, "giank123"), "51988876217", true, "ba36f476-a51b-42b9-ae3e-f9d56a02cec3", false, "giankt24" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d83683c-5094-4d63-ba8b-5adb8873ecb0", 0, "d8c194e9-afae-4a29-84e9-c10e479ee476", "sofia@locahost.com", true, false, null, "sofia@locahost.com", "sofia", hasher.HashPassword(null, "sofia123"), "51988876217", true, "be3a08ce-2860-4b02-b3a8-720819804ec4", false, "sofia" },
                    { "39f027cd-5727-427a-bafc-54ae006952fb", 0, "fc8481d1-040c-4691-9c21-345ca9983361", "nicky@locahost.com", true, false, null, "nicky@locahost.com", "nicky", hasher.HashPassword(null, "nicky123"), "51988876217", true, "052468df-ea62-4e33-a940-35e3183fbb1d", false, "nicky" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8c26c17c-ffe7-43ad-a3b3-b6d50ca71a63", "294d249b-9b57-48c1-9689-11a91abb6447" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "79ba8e3f-5c28-42cb-a03e-babcfb0b5bd8", "f284b3fd-f2cf-476e-a9b6-6560689cc48c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b305332b-ae64-4d7f-8aa2-ecb23ecb7c2a", "2d83683c-5094-4d63-ba8b-5adb8873ecb0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5e04cc88-efe0-4e53-bf10-7eb5463fb026", "39f027cd-5727-427a-bafc-54ae006952fb" });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "IdentityId","Nombre","Apellidos","Email","Phone","DateOfBirth","Country","CreatedDate","CreatedBy","LastModifiedDate","LastModifiedBy" },
                values: new object[,] 
                {
                    { "f284b3fd-f2cf-476e-a9b6-6560689cc48c", "Giancarlos", "Torres Martinez", "giankt24@localhost.com", "51988876217", new DateOnly(1998,10,9).ToShortDateString(), "Perú", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c" },
                    { "294d249b-9b57-48c1-9689-11a91abb6447", "Deyla", "Torres", "deyla@localhost.com", "51988876217", new DateOnly(2014,12,24).ToShortDateString(), "Perú", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c" },
                });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "IdentityId", "Nombre", "Apellidos", "Email", "Phone", "DateOfBirth", "Country", "CreatedDate", "CreatedBy", "LastModifiedDate", "LastModifiedBy" },
                values: new object[,]
                {
                    { "2d83683c-5094-4d63-ba8b-5adb8873ecb0", "Sofia", "Torres", "sofia@localhost.com", "51988876217", new DateOnly(2019,6,7).ToShortDateString(), "Perú", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c" },
                    { "39f027cd-5727-427a-bafc-54ae006952fb", "Nicky", "Torres", "nicky@localhost.com", "51988876217", new DateOnly(2019,6,7).ToShortDateString(), "Perú", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c", DateTime.Now.ToShortDateString(), "f284b3fd-f2cf-476e-a9b6-6560689cc48c" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

