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
       // Entities dbModel = new Entities();

        private Entities dbModel
        {
            get
            {
                return DBModel.entities;
            }
        }

        public List<tblCategory> getAllCategories()
        {
            return dbModel.tblCategory.ToList();
            //dbModel.tblCategory.Where(o=>o.parent == 0).
        }

        public List<tblCategory> getCategories1()
        {
            return dbModel.tblCategory.Where(o => o.parent == 0).ToList();
        }

        public int addCategory(tblCategory category)
        {
            dbModel.tblCategory.Add(category);
            return dbModel.SaveChanges();
        }

        public int deleteCategory(tblCategory category)
        {
            dbModel.tblCategory.Remove(category);
            return dbModel.SaveChanges();
        }
        public int deleteCategory(int id) {
            var category = dbModel.tblCategory.Find(id);
            //var category = dbModel.tblCategory.SingleOrDefault(o => o.id == id);
            //var category = dbModel.tblCategory.SingleOrDefault(o => o.id == id);
            return deleteCategory(category);
        }

        public int UpdateCategory(tblCategory category)
        {
            var old = dbModel.tblCategory.Find(category.id);
           // var old = dbModel.tblCategory.SingleOrDefault(o => o.id == category.id);
            old.name = category.name;
            old.parent = category.parent;
            //dbModel.tblCategory.Find
            //dbModel.tblCategories.u
            return dbModel.SaveChanges();
        }
    }
}
