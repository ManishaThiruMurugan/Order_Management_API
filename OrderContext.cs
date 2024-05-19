// Data/OrderContext.cs
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;
using System.Collections.Generic;

namespace OrderApi.Data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}
