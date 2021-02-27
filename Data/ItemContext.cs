using ECommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options)
        : base(options)
        { }

        public DbSet<Item> Items1 { get; set; }
        public DbSet<Item> Items2 { get; set; }
        public DbSet<Item> Items3 { get; set; }
    }
}
