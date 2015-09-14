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
            return categoryDAL.getAllCategories().ToList();
        }

        public List<tblCategory> getCategories1()
        {
            return categoryDAL.getCategories1();
        }

        public int addCategory(tblCategory category)
        {
            return categoryDAL.addCategory(category);
        }


    }
}
