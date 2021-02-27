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

        public DbSet<Item> Items { get; set; }
    }
}
