﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();


            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "1.jpg", ProductName = "Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "2.jpg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "3.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 1, ImageUrl = "4.jpg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "5.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "6.jpg", ProductName = "History", Price = 25, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "7.jpg", ProductName = "Hamlet", Price = 45, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 2, ImageUrl = "8.jpg", ProductName = "AirWrap", Price = 16_999, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 1, ImageUrl = "9.jpg", ProductName = "Airpos", Price = 6_000, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 2, ImageUrl = "10.jpg", ProductName = "Iphone 15", Price = 70_000, ShowCase = true }
                );
        }
    }
}