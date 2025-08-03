using System.Net;

namespace ApiVersion.ApiTest.Endpoints;

public partial class GetMessageEndpointV1Test
{
    [Fact]
    public async Task GetMessage_ReturnProperData_GivenValidInput()
    {
        // Arrange
        var name = "Test name";
        var version = "1.0";
        var url = $"get-message?version={version}&name={name}";

        // Act
        var response = await _client.GetAsync(url);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var content = await response.Content.ReadAsStringAsync();
        content.ShouldBe("\"Hello Test name\"");
    }
}