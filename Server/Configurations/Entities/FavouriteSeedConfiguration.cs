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
    public class FavouriteSeedConfiguration : IEntityTypeConfiguration<Favourite>
    {
        public void Configure(EntityTypeBuilder<Favourite> builder)
        {
            builder.HasData(
                new Favourite
                {
                    Id = 1,
                    ListingId = 1,
                    AccountId=null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new Favourite
                {
                    Id = 2,
                    ListingId= 2,
                    AccountId=null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }

                );

        }
    }
}
