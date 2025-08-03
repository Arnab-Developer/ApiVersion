using ApiVersion.Api.Endpoints;
using ApiVersion.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

var apiVersions = new List<AspApiVersion>()
{
    new AspApiVersion(1, 0),
    new AspApiVersion(2, 0)
};

builder.Services.AddCustomOpenApi(apiVersions);
builder.Services.AddCustomApiVersioning(apiVersions);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapCustomScalarApiReference(apiVersions);
}

var apiVersionSet = app.GetApiVersionSet(apiVersions);

app.MapGetMessageEndpointV1(apiVersionSet, apiVersions); // Call with ?version=1.0
app.MapGetMessageEndpointV2(apiVersionSet, apiVersions); // Call with ?version=2.0

app.Run();