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
    public class ConditionTypeSeedConfiguration : IEntityTypeConfiguration<ConditionType>
    {
        public void Configure(EntityTypeBuilder<ConditionType> builder)
        {
            builder.HasData(
                new ConditionType
                {
                    Id = 1,
                    Name = "New",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new ConditionType
                {
                    Id = 2,
                    Name = "WellUsed",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }

                );

        }
    }
}
