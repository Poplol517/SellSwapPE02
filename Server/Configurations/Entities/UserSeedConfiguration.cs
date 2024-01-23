using SellSwap.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SellSwap.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            },
             new ApplicationUser
             {
                 Id="673b6b78-250e-422e-9e4c-bae4bb50db41",
                 Email = "ggwp@gmail.com",
                 NormalizedEmail = "GGWP@GMAIL.COM",
                 FirstName = "Tom",
                 LastName = "Tan",
                 UserName = "ggwp@gmail.com",
                 NormalizedUserName = "GGWP@GMAIL.COM",
                 PasswordHash = hasher.HashPassword(null, "Poplol517!")
             },
             new ApplicationUser
             {
                 Id= "c3a0c046-d1b0-4607-a5d9-78b32026709c",
                 Email = "staff@gmail.com",
                 NormalizedEmail = "STAFF@GMAIL.COM",
                 FirstName = "Mary",
                 LastName = "Tan",
                 UserName = "staff@gmail.com",
                 NormalizedUserName = "STAFF@GMAIL.COM",
                 PasswordHash = hasher.HashPassword(null, "P@ssword1")
             }
            ); 
        }
    }
}