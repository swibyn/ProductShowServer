﻿using System.Web;
using System.Web.Mvc;

namespace Lmp.ProductShow.AdminWebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}