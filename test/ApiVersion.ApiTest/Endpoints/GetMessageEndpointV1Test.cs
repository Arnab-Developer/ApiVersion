using System.Net;

namespace ApiVersion.ApiTest.Endpoints;

public partial class GetMessageEndpointV1Test : IClassFixture<ApiVersionApplicationFactory>
{
    private readonly ApiVersionApplicationFactory _factory;
    private readonly HttpClient _client;

    public GetMessageEndpointV1Test(ApiVersionApplicationFactory factory)
    {
        _factory = factory;
        _client = _factory.CreateClient();
    }

    [Fact]
    public async Task Test1()
    {
        var response = await _client.GetAsync("get-message?version=1.0&name=fh");
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }
}