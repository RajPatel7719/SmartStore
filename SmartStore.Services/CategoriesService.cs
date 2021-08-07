using Smart_Store.Database;
using Smart_Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStore.Services
{
    class CategoriesService
    {
        public void SaveCategory(Category category)
        {
            using(var context = new SmartStoreContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}
