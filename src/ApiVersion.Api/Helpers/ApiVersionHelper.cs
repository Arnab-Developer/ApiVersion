namespace ApiVersion.Api.Helpers;

internal static class ApiVersionHelper
{
    public static AspApiVersions GetApiVersions()
    {
        var aspApiVersions = new AspApiVersions(new List<AspApiVersion>()
        {
            new AspApiVersion(1, 0),
            new AspApiVersion(2, 0)
        });

        return aspApiVersions;
    }
}