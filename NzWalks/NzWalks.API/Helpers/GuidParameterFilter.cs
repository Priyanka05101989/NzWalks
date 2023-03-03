using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace NzWalks.API.Helpers
{
    public class GuidParameterFilter : IParameterFilter
    {
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            if (!parameter.In.HasValue || parameter.In.Value != ParameterLocation.Query)
                return;

            if (parameter.Schema?.Type == "array" && parameter.Name.Equals("myArray"))
            {
                var value = null as IOpenApiExtension;
                parameter.Extensions.TryGetValue("explode", out value);

                if (value == null)
                    parameter.Extensions.Add("explode", new OpenApiBoolean(false));
            }
        }
    }
}
