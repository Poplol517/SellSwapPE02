﻿using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellSwap.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellSwap.Server.Configurations.Entities
{
    public class OfferSeedConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasData(
                new Offer
                {
                    Id = 1,
                    AccountId= null,
                    ListingId=1,
                    Price = 10,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new Offer
                {
                    Id = 2,
                    AccountId = null,
                    ListingId = 1,
                    Price = 100,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }

                );

        }
    }
}