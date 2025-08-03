using Scalar.AspNetCore;

namespace ApiVersion.Api.Extensions;

internal static class ScalarExtensions
{
    public static void MapCustomScalarApiReference(this IEndpointRouteBuilder builder,
        List<AspApiVersion> apiVersions)
    {
        builder.MapScalarApiReference(options =>
        {
            options.AddDocuments(apiVersions.Select(v => v.ToString()));
        });
    }
}