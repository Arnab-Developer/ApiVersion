namespace ApiVersion.Api.Helpers;

internal static class ApiVersionHelper
{
    public static List<AspApiVersion> GetApiVersions()
    {
        var apiVersions = new List<AspApiVersion>()
        {
            new AspApiVersion(1, 0),
            new AspApiVersion(2, 0)
        };

        return apiVersions;
    }
}