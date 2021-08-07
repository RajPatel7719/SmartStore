using Smart_Store.Database;
using Smart_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Store.Services
{
    public class CategoriesService
    {
        public Category GetCategoy(int ID)
        {
            using (var context = new SmartStoreContext())
            {
                return context.Categories.Find(ID);
            }
        }

        public object GetCategories()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories(int iD)
        {
            using (var context = new SmartStoreContext())
            {
                return context.Categories.ToList();
            }
        }

        public void UpdateCategory(Category category)
        {
            using (var context = new SmartStoreContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteCategory(int ID)
        {
            using (var context = new SmartStoreContext())
            {
                //context.Entry(category).State = System.Data.Entity.EntityState.Deleted;

                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }

        public void SaveCategory(Category category)
        {
            using (var context = new SmartStoreContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}
