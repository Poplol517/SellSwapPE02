using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using SellSwap.Server.Configurations.Entities;
using SellSwap.Server.Models;
using SellSwap.Shared.Domain;
using System.Drawing;

namespace SellSwap.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ConditionType> ConditionTypes { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Favourite> Favorites { get; set; }
        public DbSet<ListingStatus> ListingStatus { get; set; }
        public DbSet<ListingType> ListingType { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ListingSeedConfiguration());
            builder.ApplyConfiguration(new CategoriesSeedConfiguration());
            builder.ApplyConfiguration(new ConditionTypeSeedConfiguration());
            builder.ApplyConfiguration(new ListingTypeSeedConfiguration());
            builder.ApplyConfiguration(new ListingStatusSeedConfiguration());
            builder.ApplyConfiguration(new FavouriteSeedConfiguration());
            builder.ApplyConfiguration(new OfferSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
        }

    }
}