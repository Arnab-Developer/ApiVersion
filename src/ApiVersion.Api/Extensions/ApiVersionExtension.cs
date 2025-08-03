using Asp.Versioning;

namespace ApiVersion.Api.Extensions;

internal static class ApiVersionExtension
{
    public static void AddCustomApiVersioning(this IServiceCollection services,
        List<AspApiVersion> apiVersions)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = apiVersions[0];
            options.ReportApiVersions = true;
            options.AssumeDefaultVersionWhenUnspecified = true;

            options.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("version"));
        });
    }

    public static ApiVersionSet GetApiVersionSet(this IEndpointRouteBuilder builder,
        List<AspApiVersion> apiVersions)
    {
        var apiVersionSet = builder.NewApiVersionSet()
            .HasApiVersion(apiVersions[0])
            .HasApiVersion(apiVersions[1])
            .ReportApiVersions()
            .Build();

        return apiVersionSet;
    }
}