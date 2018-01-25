using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class CategoryDB
    {
        public void AddCategory(Category category)
        {
            using (var ctx = new ContextModel())
            {
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == category.User.ID);

                Category cat = new Category();
                cat.Name = category.Name;
                cat.User = user;
                ctx.Categories.Add(cat);
                ctx.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> catList = null;

            using (var ctx = new ContextModel())
            {
                catList = ctx.Categories.Include("User").ToList();
            }
            return catList;
        }

        public Category GetCategory(int id)
        {
            Category cat = null;

            using (var ctx = new ContextModel())
            {
                cat = ctx.Categories.FirstOrDefault(x => x.ID == id);
            }
            return cat;
        }

        public void UpdateCategory(Category category)
        {
            using (var ctx = new ContextModel())
            {
                Category cat = ctx.Categories.FirstOrDefault(x => x.ID == category.ID);
                UserTable user = ctx.UserTables.FirstOrDefault(x => x.ID == category.User.ID);

                cat.Name = category.Name;
                cat.User = user;
                ctx.SaveChanges();
            }
        }

        public void DeleteCategory(int? id)
        {
            using (var ctx = new ContextModel())
            {
                Category cat = ctx.Categories.FirstOrDefault(x => x.ID == id);
                ctx.Categories.Remove(cat);
                ctx.SaveChanges();
            }
        }
    }
}
