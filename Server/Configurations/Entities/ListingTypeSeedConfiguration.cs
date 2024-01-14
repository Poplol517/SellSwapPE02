using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellSwap.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellSwap.Server.Configurations.Entities
{
    public class ListingTypeSeedConfiguration : IEntityTypeConfiguration<ListingType>
    {
        public void Configure(EntityTypeBuilder<ListingType> builder)
        {
            builder.HasData(
                new ListingType
                {
                    Id = 1,
                    Name = "Sell",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new ListingType
                {
                    Id = 2,
                    Name = "Swap",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },
                new ListingType
                {
                    Id=3,
                    Name= "Sell and Swap",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy= "System"
                }

                );

        }
    }
}
