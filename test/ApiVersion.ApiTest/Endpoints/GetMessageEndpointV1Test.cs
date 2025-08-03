using Microsoft.AspNetCore.Mvc.Testing;

namespace ApiVersion.ApiTest.Endpoints;

[Collection("WebApplicationFactoryCollection")]
public partial class GetMessageEndpointV1Test : IDisposable
{
    private readonly HttpClient _client;
    private bool disposedValue;

    public GetMessageEndpointV1Test(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _client.Dispose();
            disposedValue = true;
        }
    }

    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    ~GetMessageEndpointV1Test()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(false);
    }
}