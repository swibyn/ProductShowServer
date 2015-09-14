using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lmp.ProductShow.BLL;
using Lmp.ProductShow.Model;
using Lmp.ProductShow.AdminWebApp.Filters;
using Lmp.ProductShow.AdminWebApp.Models;

namespace Lmp.ProductShow.AdminWebApp.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Index()
        {
            ViewData["categories"] = new CategoryBLL().getAllCategories();
            ViewData["category1"] = new CategoryBLL().getCategories1();
            return View();
        }
        public ActionResult AddCategory(CategoryModel model)
        {
            var effectedRow = new CategoryBLL().addCategory(model.totblCategory());
            return Content("" + effectedRow);
        }
        public ActionResult Add(long? parent, string name)
        {
            var category = new tblCategory();
            category.parent = parent;
            category.name = name;
            int effected = new CategoryBLL().addCategory(category);
            if (effected == 1)
            {
                return Content("OK");
            }
            else
            {
                return Content("类目新增失败");
            }

        }
        public ActionResult Delete(int id)
        {
 
        }

    }
}
