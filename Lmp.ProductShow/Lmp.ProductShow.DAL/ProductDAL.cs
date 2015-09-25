using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.Model;


namespace Lmp.ProductShow.DAL
{
    public class ProductDAL
    {
        public List<tblProduct> getProductsByCategoryId(long id)
        {
            return DBModel.entities.tblProduct.Where(o=>o.categoryid==id).ToList();
        }

        public List<tblProduct> getAllProducts()
        {
            return DBModel.entities.tblProduct.ToList();
        }

        public int addProduct(tblProduct product)
        {
            DBModel.entities.tblProduct.Add(product);
            return DBModel.entities.SaveChanges();
        }

        public int deleteProduct(tblProduct product)
        {
            DBModel.entities.tblProduct.Remove(product);
            return DBModel.entities.SaveChanges();
        }

        public int deleteProduct(long id)
        {
            DBModel.entities.tblProduct.Remove(DBModel.entities.tblProduct.Find(id));
            return DBModel.entities.SaveChanges();
        }

        public int updateProduct(tblProduct product)
        {
            var old = DBModel.entities.tblProduct.Find(product.id);
            old.name = product.name;
            old.categoryid = product.categoryid;
            return DBModel.entities.SaveChanges();
        }
    }
}
