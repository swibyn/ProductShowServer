using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lmp.ProductShow.DAL;
using Lmp.ProductShow.Model;

namespace Lmp.ProductShow.BLL
{
    public class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();

        public List<tblProduct> getProductsByCategoryId(long id)
        {
            return productDAL.getProductsByCategoryId(id);
        }

        public List<tblProduct> getAllProducts()
        {
            return productDAL.getAllProducts();
        }

        public int addProduct(tblProduct product)
        {
            return productDAL.addProduct(product);
        }

        public int deleteProduct(tblProduct product)
        {
            return productDAL.deleteProduct(product);
        }

        public int deleteProduct(long id)
        {
            return productDAL.deleteProduct(id);
        }

        public int updateProduct(tblProduct product)
        {
            return productDAL.updateProduct(product);
        }
    }
}
