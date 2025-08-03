var builder = WebApplication.CreateBuilder(args);

var apiVersions = ApiVersionHelper.GetApiVersions();

builder.Services.AddCustomApiVersioning(apiVersions.DefaultVersion);
builder.Services.AddCustomOpenApi(apiVersions);

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