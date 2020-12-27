﻿using GREat.REST.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GREat.REST.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("RegistrationDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}