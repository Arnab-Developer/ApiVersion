using Asp.Versioning.Builder;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ApiVersion.Api.Endpoints;

internal static class GetMessageEndpoint
{
    public static void MapGetMessageEndpoint(this IEndpointRouteBuilder builder,
        ApiVersionSet apiVersionSet, List<AspApiVersion> apiVersions)
    {
        builder
            .MapGet("get-message", HandleV1)
            .WithApiVersionSet(apiVersionSet)
            .WithGroupName(apiVersions[0].ToString())
            .MapToApiVersion(apiVersions[0]);

        builder
            .MapGet("get-message", HandleV2)
            .WithApiVersionSet(apiVersionSet)
            .WithGroupName(apiVersions[1].ToString())
            .MapToApiVersion(apiVersions[1]);
    }

    private static async Task<Results<Ok<string>, NotFound<string>>> HandleV1(string name)
    {
        await Task.Delay(500);
        var message = $"Hello {name}";

        return !string.IsNullOrEmpty(message)
            ? TypedResults.Ok(message)
            : TypedResults.NotFound("Message not found");
    }

    private static async Task<Results<Ok<string>, NotFound<string>>> HandleV2(string name, int age)
    {
        await Task.Delay(500);
        var message = $"Hello {name}. Your age is {age}";

        return !string.IsNullOrEmpty(message)
            ? TypedResults.Ok(message)
            : TypedResults.NotFound("Message not found");
    }
}