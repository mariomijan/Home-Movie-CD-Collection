using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core;
using Business_Logic;

namespace HomeCollection
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CategoryService : ICategoryService
    {
        private CategoryCtrl catCtrl;

        public CategoryService()
        {
            catCtrl = new CategoryCtrl();
        }

        public void AddCategory(Category category)
        {
            catCtrl.AddCategory(category);
        }

        public void DeleteCategory(int? id)
        {
            catCtrl.DeleteCategory(id);
        }

        public List<Category> GetAllCategories()
        {
            return catCtrl.GetAllCategories();
        }

        public Category GetCategory(int id)
        {
            return catCtrl.GetCategory(id);
        }

        public void UpdateCategory(Category category)
        {
            catCtrl.UpdateCategory(category);
        }
    }
}
