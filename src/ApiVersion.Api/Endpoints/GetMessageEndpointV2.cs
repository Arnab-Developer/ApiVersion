namespace ApiVersion.Api.Endpoints;

internal static class GetMessageEndpointV2
{
    public static void MapGetMessageEndpointV2(this IEndpointRouteBuilder builder,
        ApiVersionSet apiVersionSet, List<AspApiVersion> apiVersions)
    {
        builder
            .MapGet("get-message", Handle)
            .WithApiVersionSet(apiVersionSet)
            .WithGroupName(apiVersions[1].ToString())
            .MapToApiVersion(apiVersions[1]);
    }

    private static async Task<Results<Ok<string>, NotFound<string>>> Handle(string name, int age)
    {
        await Task.Delay(500);
        var message = $"Hello {name}. Your age is {age}";

        return !string.IsNullOrEmpty(message)
            ? TypedResults.Ok(message)
            : TypedResults.NotFound("Message not found");
    }
}