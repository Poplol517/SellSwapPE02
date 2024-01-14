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
    public class ListingSeedConfiguration : IEntityTypeConfiguration<Listing>
    {
        public void Configure(EntityTypeBuilder<Listing> builder)
        {
            builder.HasData(
                new Listing
                {
                    Id = 1,
                    Name = "Iphone",
                    ConditionTypeId = 2,
                    Description = "well used without a scratch",
                    Price = 1200,
                    CategoryId = 1,
                    UserId = null,
                    ListingStatusId = 1, //Avaliable
                    ListingTypeId = 1, //Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new Listing
                {
                    Id = 2,
                    Name = "POP Mart figure",
                    ConditionTypeId = 1,
                    Description = "well used without a scratch",
                    Price = null,
                    CategoryId = 1,
                    UserId = null,
                    ListingStatusId = 1, //Avaliable
                    ListingTypeId = 2, //Swap
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }

                ) ;

        }
    }
}
