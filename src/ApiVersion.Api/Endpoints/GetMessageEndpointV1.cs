namespace ApiVersion.Api.Endpoints;

internal static class GetMessageEndpointV1
{
    public static void MapGetMessageEndpointV1(this IEndpointRouteBuilder builder,
        ApiVersionSet apiVersionSet, AspApiVersions apiVersions)
    {
        builder
            .MapGet("get-message", HandleV1)
            .WithApiVersionSet(apiVersionSet)
            .WithGroupName(apiVersions[0].ToString())
            .MapToApiVersion(apiVersions[0]);
    }

    private static async Task<Results<Ok<string>, NotFound<string>>> HandleV1(string name)
    {
        await Task.Delay(500);
        var message = $"Hello {name}";

        return !string.IsNullOrEmpty(message)
            ? TypedResults.Ok(message)
            : TypedResults.NotFound("Message not found");
    }
}