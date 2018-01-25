using Core;
using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class CategoryCtrl
    {
        private CategoryDB catDb;

        public CategoryCtrl()
        {
            catDb = new CategoryDB();
        }

        public void AddCategory(Category category)
        {
            catDb.AddCategory(category);
        }

        public List<Category> GetAllCategories()
        {
            return catDb.GetAllCategories();
        }

        public Category GetCategory(int id)
        {
            return catDb.GetCategory(id);
        }

        public void UpdateCategory(Category category)
        {
            catDb.UpdateCategory(category);
        }

        public void DeleteCategory(int? id)
        {
            catDb.DeleteCategory(id); 
                
        }
    }
}
