using Smart_Store.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Store.Database
{
    public class SmartStoreContext : DbContext, IDisposable
    {
        public SmartStoreContext() : base("SmartStoreConnection")
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
