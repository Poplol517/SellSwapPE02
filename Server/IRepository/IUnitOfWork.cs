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
        IGenericRepository<Swap> Swaps { get; }
        IGenericRepository<ProductStatus> ProductStatus { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<PaymentType> PaymentTypes { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Meetup> Meetups { get; }
        IGenericRepository<Favourites> Favourites { get; }
        IGenericRepository<Delivery> Deliverys { get; }
        IGenericRepository<Category> Categorys { get; }

    }
}