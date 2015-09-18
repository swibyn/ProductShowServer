using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.Model;


namespace Lmp.ProductShow.DAL
{
    public class CategoryDAL
    {
        ProductShowEntities dbModel = new ProductShowEntities();
        public List<tblCategory> getAllCategories()
        {
            return dbModel.tblCategories.ToList();
        }

        public List<tblCategory> getCategories1()
        {
            return dbModel.tblCategories.Where(o => o.parent == null).ToList();
        }

        public int addCategory(tblCategory category)
        {
            dbModel.tblCategories.Add(category);
            return dbModel.SaveChanges();
        }

        public int deleteCategory(tblCategory category)
        {
            dbModel.tblCategories.Remove(category);
            return dbModel.SaveChanges();
        }
        public int deleteCategory(int id) {
            var category = dbModel.tblCategories.FirstOrDefault(o => o.id == id);
            return deleteCategory(category);
        }

        public tblCategory UpdateCategory(tblCategory category)
        {
            //dbModel.tblCategories.u
            return null;
        }
    }
}
