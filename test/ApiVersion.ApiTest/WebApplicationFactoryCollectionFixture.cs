using Microsoft.AspNetCore.Mvc.Testing;

namespace ApiVersion.ApiTest;

[CollectionDefinition("WebApplicationFactoryCollection")]
public class WebApplicationFactoryCollectionFixture
    : ICollectionFixture<WebApplicationFactory<Program>>
{

}