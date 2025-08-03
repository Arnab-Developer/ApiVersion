using System.Net;

namespace ApiVersion.ApiTest.Endpoints;

public partial class GetMessageEndpointV2Test
{
    [Fact]
    public async Task GetMessage_ReturnProperData_GivenValidInput()
    {
        // Arrange
        var name = "Test name";
        var age = 50;
        var version = "2.0";
        var url = $"get-message?version={version}&name={name}&age={age}";

        // Act
        var response = await _client.GetAsync(url);

        // Assert
        response.StatusCode.ShouldBe(HttpStatusCode.OK);
        var content = await response.Content.ReadAsStringAsync();
        content.ShouldBe("\"Hello Test name. Your age is 50\"");
    }
}