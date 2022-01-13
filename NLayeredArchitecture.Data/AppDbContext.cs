﻿using Microsoft.EntityFrameworkCore;
using NLayeredArchitecture.Core.Models;
using NLayeredArchitecture.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredArchitecture.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
