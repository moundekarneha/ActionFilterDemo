using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Filters;
using System.Web.Mvc;
using System.Diagnostics;


namespace ActionFilterDemo.Filters
{ 
    public class CustomActionFilter : FilterAttribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("hello from action filter - OnActionExecuted");
            filterContext.Controller.ViewBag.Message = "We are from action filter";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("hello from action filter - OnActionExecuting");
        }
    }
}