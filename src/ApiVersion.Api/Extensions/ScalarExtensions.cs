using Scalar.AspNetCore;

namespace ApiVersion.Api.Extensions;

internal static class ScalarExtensions
{
    public static void MapCustomScalarApiReference(this IEndpointRouteBuilder builder,
        AspApiVersions apiVersions)
    {
        builder.MapScalarApiReference(options =>
        {
            var apiVersionsStrings = apiVersions.Select(v => v.ToString());
            options.AddDocuments(apiVersionsStrings);
        });
    }
}