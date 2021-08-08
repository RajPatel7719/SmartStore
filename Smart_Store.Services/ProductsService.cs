using Smart_Store.Database;
using Smart_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Store.Services
{
    public class ProductsService
    {
        public Product GetProduct(int ID)
        {
            using (var context = new SmartStoreContext())
            {
                return context.Products.Find(ID);
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new SmartStoreContext())
            {
                return context.Products.ToList();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new SmartStoreContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int ID)
        {
            using (var context = new SmartStoreContext())
            {
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;

                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public void SaveProduct(Product product)
        {
            using (var context = new SmartStoreContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
