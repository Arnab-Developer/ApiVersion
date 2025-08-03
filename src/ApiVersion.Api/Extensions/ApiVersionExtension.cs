using Asp.Versioning;

namespace ApiVersion.Api.Extensions;

internal static class ApiVersionExtension
{
    public static void AddCustomApiVersioning(this IServiceCollection services,
        AspApiVersion defaultApiVersion)
    {
        services
            .AddApiVersioning(options =>
            {
                options.DefaultApiVersion = defaultApiVersion;
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;

                options.ApiVersionReader = ApiVersionReader.Combine(
                    new QueryStringApiVersionReader("version")
                );
            })
            .AddApiExplorer(options =>
            {
                options.GroupNameFormat = "'version'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
    }

    public static ApiVersionSet GetApiVersionSet(this IEndpointRouteBuilder builder,
        AspApiVersions apiVersions)
    {
        var apiVersionSet = builder.NewApiVersionSet()
            .HasApiVersion(apiVersions[0])
            .HasApiVersion(apiVersions[1])
            .ReportApiVersions()
            .Build();

        return apiVersionSet;
    }
}