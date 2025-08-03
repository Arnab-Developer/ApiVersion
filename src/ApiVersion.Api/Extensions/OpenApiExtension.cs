namespace ApiVersion.Api.Extensions;

internal static class OpenApiExtension
{
    public static void AddCustomOpenApi(this IServiceCollection services,
        List<AspApiVersion> apiVersions)
    {
        foreach (var apiVersion in apiVersions)
        {
            services.AddOpenApi(apiVersion.ToString());
        }
    }
}