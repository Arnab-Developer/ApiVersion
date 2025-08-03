using Asp.Versioning;
using AspApiVersion = Asp.Versioning.ApiVersion;

namespace ApiVersion.Api.Extensions;

internal static class ApiVersion
{
    public static void AddApiVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new AspApiVersion(1, 0);
            options.ReportApiVersions = true;
            options.AssumeDefaultVersionWhenUnspecified = true;

            options.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("version"));
        });
    }
}