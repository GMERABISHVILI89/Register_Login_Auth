using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace RegisterLoginJWTMTO20.Filters
{
    public class ExecutionTimeFilter : IActionFilter
    {
        private Stopwatch _stopwatch;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            File.WriteAllTextAsync("C:/Users/adome/OneDrive/Desktop/logger.txt",
                $"Action {context.ActionDescriptor.DisplayName} executed in {_stopwatch.ElapsedMilliseconds}");
        }

    }
}
