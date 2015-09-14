using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lmp.ProductShow.BLL;
using Lmp.ProductShow.Model;

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
        public ActionResult AddCategory(tblCategory category)
        {
            var effectedRow = new CategoryBLL().addCategory(category);
            return Content("" + effectedRow);
        }
        //public ActionResult Add(string parentId, string categoryname)
        //{
        //   var category = new CategoryBLL().addCategory(parentId, categoryname);
        //   if (category != null)
        //   {
        //       return Content("OK");
        //   }
        //   else
        //   {
        //       return Content("类目新增失败");
        //   }

        //}

    }
}
