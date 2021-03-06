﻿using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions option) : base(option)
        {
            
        }

        public DbSet<Value> Values { get; set; }
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Value>().HasData(
                new Value {
                    Id = 1,
                    Name = "Value001"
                },
                new Value {
                    Id = 2,
                    Name = "Value002"
                }
            );
        }

    }
    

}
