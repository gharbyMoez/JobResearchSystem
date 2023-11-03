using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace JobResearchSystem.API
{
    public class SecurityRequirementsOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Security == null)
            {
                operation.Security = new List<OpenApiSecurityRequirement>();
            }

            // Check if the action has an [Authorize] attribute
            var hasAuthorizeAttribute = context.MethodInfo.GetCustomAttributes(inherit: true)
                .Any(a => a.GetType() == typeof(AuthorizeAttribute));

            if (!hasAuthorizeAttribute)
            {
                // Remove the security requirement for endpoints that don't have [Authorize] attribute
                operation.Security.Clear();
            }
        }
    }

}
