using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CafeOrderingSystem.Models;

namespace CafeOrderingSystem.Context
{
    public class OrderManagementContext:DbContext
    {
        public OrderManagementContext() :base ("OrderManagementContextDB")
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}