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
            var categoryBLL = new CategoryBLL();
            //ViewData["categories"] = categoryBLL.getAllCategories();
            //ViewData["category1"] = categoryBLL.getCategories1();
            ViewData["category1Model"] = categoryBLL.getCategoryModel();
            return View("Index");
        }

        //public ActionResult AddCategory(CategoryModel model)
        //{
        //    var effectedRow = new CategoryBLL().addCategory(model.totblCategory());
        //    return Content("" + effectedRow);
        //}
        
        public ActionResult Add(long? parent, string name)
        {
            var category = new tblCategory();
            category.parent = parent;
            category.name = name;
            int effected = new CategoryBLL().addCategory(category);
            return Content("" + effected);
        }

        public ActionResult Delete(int id)
        {
            var effectedRow = new CategoryBLL().deleteCategory(id);
            return Content("" + effectedRow); 
        }

        public ActionResult Update(int id, int parent, string name)
        {
            var category = new tblCategory();
            category.id = id;
            category.parent = parent;
            category.name = name;

            var effectedRow = new CategoryBLL().UpdateCategory(category);
            return Content("" + effectedRow);
        }

    }
}
