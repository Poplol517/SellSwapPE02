using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellSwap.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                    Image = "/images/iphone-15-finish-select-202309-6-1inch-black.jpg",
                    ConditionTypeId = 2,
                    Description = "well used without a scratch",
                    Price = 1200.00,
                    CategoryId = 1,
                    AccountId = null,
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
                    Image ="/images/vn-11134207-7r98o-ll5dstlhxsjad9_880302e6f6444e4189236838fbb1c647.jpg",
                    ConditionTypeId = 1,
                    Description = "well used without a scratch",
                    Price = null,
                    CategoryId = 2,
                    AccountId = null,
                    ListingStatusId = 1, //Avaliable
                    ListingTypeId = 2, //Swap
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },
                 new Listing
                 {
                     Id = 3,
                     Name = "Smart TV",
                     Image = "/images/Hisense-A4-32-HD-Smart-TV.jpg",
                     ConditionTypeId = 2,
                     Description = "Full HD Smart TV with great picture quality",
                     Price = 800.00,
                     CategoryId = 3, // Electronics
                     AccountId = null,
                     ListingStatusId = 1, // Available
                     ListingTypeId = 1, // Sell
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System"
                 },

                // Listing 4
                new Listing
                {
                    Id = 4,
                    Name = "Leather Sofa",
                    Image = "/images/_mg_9210_2.jpg",
                    ConditionTypeId = 3,
                    Description = "Comfortable leather sofa in excellent condition",
                    Price = 500.00,
                    CategoryId  = 4, // Furniture
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 2, // Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                // Listing 5
                new Listing
                {
                    Id = 5,
                    Name = "Men's Winter Jacket",
                    Image = "/images/download.jpg",
                    ConditionTypeId = 1,
                    Description = "Stylish men's winter jacket, size XL",
                    Price = 80.00,
                    CategoryId = 5, // Clothing & Accessories
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 1, // Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                // Listing 6
                new Listing
                {
                    Id = 6,
                    Name = "Garden Table and Chairs",
                    Image = "/images/img_0509-edit.jpg",
                    ConditionTypeId = 2,
                    Description = "Outdoor table and chairs set for your garden",
                    Price = 150.00,
                    CategoryId = 6, // Home & Garden
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 1, // Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                // Listing 7
                new Listing
                {
                    Id = 7,
                    Name = "Harry Potter Book Set",
                    Image = "/images/718X1SWIsjL._AC_UF1000,1000_QL80_.jpg",
                    ConditionTypeId = 2,
                    Description = "Complete set of Harry Potter books in good condition",
                    Price = 60.00,
                    CategoryId = 7, // Books & Media
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 2, // Swap
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                // Listing 8
                new Listing
                {
                    Id = 8,
                    Name = "Mountain Bike",
                    Image = "/images/download (1).jpg",
                    ConditionTypeId = 3,
                    Description = "Hardtail mountain bike with front suspension",
                    Price = 300.00,
                    CategoryId = 8, // Sports & Outdoors
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 1, // Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },
                new Listing
                {
                    Id = 9,
                    Name = "Samsung Galaxy S21",
                    Image = "/images/81IWsqrVMTL._AC_UF894,1000_QL80_.jpg",
                    ConditionTypeId = 2,
                    Description = "Brand new in box, never opened.",
                    Price = 899.99,
                    CategoryId = 1, // Phone
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 2, // Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },
                new Listing
                {
                    Id = 10,
                    Name = "Lego Star Wars Millennium Falcon",
                    Image = "/images/81kmuPJ9IOL.jpg",
                    ConditionTypeId = 1,
                    Description = "Complete set with original box.",
                    Price = null,
                    CategoryId = 9, // Toys & Games
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 2, // Swap
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },
                new Listing
                {
                    Id = 11,
                    Name = "Amazon Echo Dot (3rd Gen)",
                    Image = "/images/amazon_echo_dot_3__echo_dot_3r_1610044909_d1b25298_progressive.jpg",
                    ConditionTypeId = 3,
                    Description = "Used but in excellent condition.",
                    Price = 30.00,
                    CategoryId = 3, // Electronics
                    AccountId = null,
                    ListingStatusId = 1, // Available
                    ListingTypeId = 1, // Sell
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }

                ) ;

        }
    }
}
