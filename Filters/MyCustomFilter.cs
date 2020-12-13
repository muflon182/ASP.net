using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NewBrandingStyle.Web.Filters
{
    public class MyCustomFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.TryGetValue("name", out var value))
            {
                Console.WriteLine($"{value} introduced!");
            }
            else
            {
                Console.WriteLine("This action does not have a \"name\" parameter");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var viewReturned = context.Result is ViewResult;

            Console.WriteLine($"View returned: {viewReturned}");
        }
    }
}