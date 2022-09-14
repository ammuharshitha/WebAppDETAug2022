using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCProgams.Filters
{
    public class ActionFiltersAttribute
    {
        internal void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        internal void OnActionExecuting(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }
    }
}