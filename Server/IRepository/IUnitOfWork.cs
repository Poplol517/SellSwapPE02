using SellSwap.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellSwap.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<User> Users { get; }
        IGenericRepository<Offer> Offers { get; }
        IGenericRepository<ListingStatus> ListingStatus { get; }
        IGenericRepository<Listing> Listings { get; }
        IGenericRepository<Favourite> Favourites { get; }
        IGenericRepository<Category> Categorys { get; }

    }
}