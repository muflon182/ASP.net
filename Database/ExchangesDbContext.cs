﻿using System;
using Microsoft.EntityFrameworkCore;
using WebApplication.Web.Entities;

namespace WebApplication.Web.Databases
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<ProductsEntity> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //fluent configuration
        }
    }
}