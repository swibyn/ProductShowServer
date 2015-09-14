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

        //public tblCategory addCategory(string parentId, string categoryName)
        //{
        //    return addCategory(new tblCategory() { parent = Convert.ToInt32(parentId), name = categoryName });
        //}
    }
}
