using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace RegisterLoginJWTMTO20.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var response = new
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = "Unexpected error occured",
                DetailedException = context.Exception.GetFullMessage()
            };

            List<string> Messages = new List<string>();
            Messages.Add(response.StatusCode.ToString());
            Messages.Add(response.Message);
            Messages.Add(response.DetailedException);

            File.WriteAllText("C:/Users/adome/OneDrive/Desktop/Exceptions.txt", string.Join("-->", Messages));

            context.Result = new ObjectResult(response)
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };
            context.ExceptionHandled = true;
        }
    }
}
