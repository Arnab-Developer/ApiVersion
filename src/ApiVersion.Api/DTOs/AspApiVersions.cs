namespace ApiVersion.Api.DTOs;

internal class AspApiVersions : List<AspApiVersion>
{
    public AspApiVersion DefaultVersion
    {
        get
        {
            return this[0];
        }
    }
}