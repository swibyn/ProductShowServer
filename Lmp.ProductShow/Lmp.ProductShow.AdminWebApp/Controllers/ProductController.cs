using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lmp.ProductShow.BLL;
using Lmp.ProductShow.Model;

namespace Lmp.ProductShow.AdminWebApp.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index(int categoryid=1)
        {
            var categoryModel = new CategoryBLL().getCategoryModel();
            var firstCategory2 = categoryModel.First().children.First();
            ViewData["Products"] = new ProductBLL().getProductsByCategoryId(firstCategory2.id);
            //if (categoryid == -1)
            //{
            //    ViewData["Products"] = new ProductBLL().getAllProducts();
            //}
            //else
            //{
            //    ViewData["Products"] = new ProductBLL().getProductsByCategoryId(categoryid);
            //}
            ViewData["category1Model"] = categoryModel;
            return View();
        }

        public ActionResult Products(long? categoryid)
        {
            ViewData["Products"] = new ProductBLL().getProductsByCategoryId(categoryid ?? 0);
            return View();
        }

        public ActionResult Add(string name, long categoryid)
        {
            tblProduct product = new tblProduct();
            product.name = name;
            product.categoryid = categoryid;
            var effectedRow = new ProductBLL().addProduct(product);
            return Content("" + effectedRow);
        }

        public ActionResult Delete(long id)
        {
            var effectedRow = new ProductBLL().deleteProduct(id);
            return Content("" + effectedRow);
        }

    }
}
