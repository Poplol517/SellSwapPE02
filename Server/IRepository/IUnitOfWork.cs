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
        IGenericRepository<Account> Accounts { get; }
        IGenericRepository<Offer> Offers { get; }
        IGenericRepository<ListingStatus> ListingStatus { get; }
        IGenericRepository<Listing> Listings { get; }
        IGenericRepository<ListingType> ListingTypes { get; }
        IGenericRepository<ConditionType> ConditionTypes { get; }
        IGenericRepository<Favourite> Favourites { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<ChatMessage> ChatMessages { get; }
        IGenericRepository<Conversation> Conversations { get; }
    }
}