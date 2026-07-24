using Microsoft.AspNetCore.Mvc.Filters;
public class CustomActionFilter:ActionFilterAttribute{
public override void OnActionExecuting(ActionExecutingContext context){}
}