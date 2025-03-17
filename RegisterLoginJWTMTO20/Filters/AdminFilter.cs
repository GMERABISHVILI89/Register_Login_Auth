using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace RegisterLoginJWTMTO20.Filters
{
    public class AdminFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;
            if(!user.HasClaim(x => x.Type == ClaimTypes.Role && x.Value == "Admin"))
            {
                context.Result = new ForbidResult();
            }
        }
    }
}
