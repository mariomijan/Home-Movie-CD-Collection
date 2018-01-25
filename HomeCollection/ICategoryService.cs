using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HomeCollection
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        void AddCategory(Category category);

        [OperationContract]
        List<Category> GetAllCategories();

        [OperationContract]
        Category GetCategory(int id);

        [OperationContract]
        void UpdateCategory(Category category);

        [OperationContract]
        void DeleteCategory(int? id);
    }
}
