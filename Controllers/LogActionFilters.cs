using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Filters.Controllers
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Log("OnActionExecuting", context.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Log("OnActionExecuted", context.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Log("OnResultExecuting", context.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Log("OnResultExecuted", context.RouteData);
        }

        private void Log(string methodName, Microsoft.AspNetCore.Routing.RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = $"{methodName} - Controller: {controllerName}, Action: {actionName}";
            Console.WriteLine(message);
        }
    }
}
