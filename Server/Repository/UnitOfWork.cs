using SellSwap.Server.Data;
using SellSwap.Server.IRepository;
using SellSwap.Server.Models;
using SellSwap.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using SellSwap.Server.Repository;

namespace SellSwap.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Account> _users;
        private IGenericRepository<Listing> _listings;
        private IGenericRepository<ListingStatus> _listingstatus;
        private IGenericRepository<ListingType> _listingtype;
        private IGenericRepository<ConditionType> _conditiontype;
        private IGenericRepository<Offer> _offers;
        private IGenericRepository<ApprovedOffer> _approvedoffers;
        private IGenericRepository<RejectedOffer> _rejectedoffers;
        private IGenericRepository<Favourite> _favourites;
        private IGenericRepository<Category> _categories;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Account> Users
            => _users ??= new GenericRepository<Account>(_context);
        public IGenericRepository<Listing> Listings
            => _listings ??= new GenericRepository<Listing>(_context);
        public IGenericRepository<ListingStatus> ListingStatus
            => _listingstatus ??= new GenericRepository<ListingStatus>(_context);
        public IGenericRepository<Offer> Offers
            => _offers ??= new GenericRepository<Offer>(_context);
        public IGenericRepository<ApprovedOffer> ApprovedOffers
    => _approvedoffers ??= new GenericRepository<ApprovedOffer>(_context);
        public IGenericRepository<RejectedOffer> RejectedOffers
    => _rejectedoffers ??= new GenericRepository<RejectedOffer>(_context);
        public IGenericRepository<Favourite> Favourites
            => _favourites ??= new GenericRepository<Favourite>(_context);
        public IGenericRepository<Category> Categories
            => _categories ??= new GenericRepository<Category>(_context);
        public IGenericRepository<ConditionType> ConditionTypes
            => _conditiontype ??= new GenericRepository<ConditionType>(_context);
        public IGenericRepository<ListingType> ListingTypes
            => _listingtype ??= new GenericRepository<ListingType>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                //((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}