﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StockApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
    }
}
