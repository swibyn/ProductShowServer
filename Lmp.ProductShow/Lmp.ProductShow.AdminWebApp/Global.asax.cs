using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net;

namespace Lmp.ProductShow.AdminWebApp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
        protected void Application_Error(object sender, EventArgs e)
        {
            var a = 1 + 1;
             
            var ex = Server.GetLastError(); 
            ILog log = log4net.LogManager.GetLogger("aaaaaaaaa");
                 log.Error(ex);
            /*
           // Log.Error(ex); //记录日志信息 
            var httpStatusCode = (ex is HttpException) ? (ex as HttpException).GetHttpCode() : 500; //这里仅仅区分两种错误 
            var httpContext = ((MvcApplication)sender).Context; 
            httpContext.ClearError(); 
            httpContext.Response.Clear(); 
            httpContext.Response.StatusCode = httpStatusCode; 
            var shouldHandleException = true; 
            HandleErrorInfo errorModel; 
     
            var routeData = new RouteData(); 
            routeData.Values["controller"] = "Utility"; 
     
            switch (httpStatusCode) 
            { 
                case 404: 
                    routeData.Values["action"] = "PageNotFound"; 
                    errorModel = new HandleErrorInfo(new Exception(string.Format("No page Found", httpContext.Request.UrlReferrer), ex), "Utility", "PageNotFound"); 
                    break; 
     
                default: 
                    routeData.Values["action"] = "Error"; 
                    Exception exceptionToReplace = null; //这里使用了EntLib的异常处理模块的一些功能 
                    //shouldHandleException = ExceptionPolicy.HandleException(ex, "LogAndReplace", out exceptionToReplace); 
                    //errorModel = new HandleErrorInfo(exceptionToReplace, "Utility", "Error"); 
                    break; 
            } 
     
            if (shouldHandleException) 
            { 
                //var controller = new UtilityController(); 
                //controller.ViewData.Model = errorModel; //通过代码路由到指定的路径 
                //((IController)controller).Execute(new RequestContext(new HttpContextWrapper(httpContext), routeData)); 
            } 
             */
        } 
    }       
    
}