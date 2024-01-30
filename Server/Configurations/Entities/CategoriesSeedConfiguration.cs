using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellSwap.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SellSwap.Server.Configurations.Entities
{
    public class CategoriesSeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "Phone",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new Category
                {
                    Id = 2,
                    Name = "Figure",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },
                
                new Category
                {
                    Id = 3,
                    Name = "Electronics",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

               
                new Category
                {
                    Id = 4,
                    Name = "Furniture",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

               
                new Category
                {
                    Id = 5,
                    Name = "Clothing & Accessories",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                
                new Category
                {
                    Id = 6,
                    Name = "Home & Garden",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                
                new Category
                {
                    Id = 7,
                    Name = "Books & Media",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new Category
                {
                    Id = 8,
                    Name = "Sports & Outdoors",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                
                new Category
                {
                    Id = 9,
                    Name = "Toys & Games",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }


                                );

        }
    }
}
