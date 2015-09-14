using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lmp.ProductShow.BLL;

namespace Lmp.ProductShow.AdminWebApp.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            AdminBLL adminBLL = new AdminBLL();
            ViewData["admins"] = adminBLL.getAllAdmins();
            return View();
        }

       

        public ActionResult Delete(int id)
        {
            AdminBLL adminBLL = new AdminBLL();
            adminBLL.deleteAdmin(id);
            return RedirectToAction("Index");
        }
    }
}
