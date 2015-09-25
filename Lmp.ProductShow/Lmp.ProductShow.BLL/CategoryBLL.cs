using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.DAL;
using Lmp.ProductShow.Model;

namespace Lmp.ProductShow.BLL
{
    public class CategoryBLL
    {
        CategoryDAL categoryDAL = new CategoryDAL();
        public List<tblCategory> getAllCategories()
        {
            return categoryDAL.getAllCategories();
        }


        public List<CategoryModel> getCategoryModel()
        {
            var list = getAllCategories();
            
            var models=list.ConvertAll<CategoryModel>(o=>new CategoryModel(){
                id=o.id,
                name=o.name,
                parent=o.parent ?? 0, 
                children=new List<CategoryModel>()
            });

            var category1Model = models.FindAll(o=>o.parent == 0);
            models.RemoveAll(o=>o.parent == 0);
            foreach(var model in models){
                category1Model.Find(o=>o.id == model.parent).children.Add(model);
            }
            return category1Model;
        }

        public List<tblCategory> getCategories1()
        {
            return categoryDAL.getCategories1();
        }

        public int addCategory(tblCategory category)
        {
            return categoryDAL.addCategory(category);
        }

        public int deleteCategory(tblCategory category)
        {
            return categoryDAL.deleteCategory(category);
        }

        public int deleteCategory(int id)
        {
            return categoryDAL.deleteCategory(id);
        }

        public int UpdateCategory(tblCategory category)
        {
            return categoryDAL.UpdateCategory(category);
        }
    }
    
}
