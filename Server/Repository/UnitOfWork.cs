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
        private IGenericRepository<User> _users;
        private IGenericRepository<Swap> _swaps;
        private IGenericRepository<ProductStatus> _productstatus;
        private IGenericRepository<Product> _products;
        private IGenericRepository<PaymentType> _paymenttypes;
        private IGenericRepository<Payment> _payments;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<Meetup> _meetups;
        private IGenericRepository<Favourites> _favourites;
        private IGenericRepository<Delivery> _deliverys;
        private IGenericRepository<Category> _category;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<User> Users
            => _users ??= new GenericRepository<User>(_context);
        public IGenericRepository<Swap> Swaps
            => _swaps ??= new GenericRepository<Swap>(_context);
        public IGenericRepository<ProductStatus> ProductStatus
            => _productstatus ??= new GenericRepository<ProductStatus>(_context);
        public IGenericRepository<Product> Products
            => _products ??= new GenericRepository<Product>(_context);
        public IGenericRepository<PaymentType> PaymentTypes
            => _paymenttypes ??= new GenericRepository<PaymentType>(_context);
        public IGenericRepository<Payment> Payments
            => _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<Meetup> Meetups
            => _meetups ??= new GenericRepository<Meetup>(_context);
        public IGenericRepository<Favourites> Favourites
            => _favourites ??= new GenericRepository<Favourites>(_context);
        public IGenericRepository<Delivery> Deliverys
            => _deliverys ??= new GenericRepository<Delivery>(_context);
        public IGenericRepository<Category> Categorys
            => _category ??= new GenericRepository<Category>(_context);

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