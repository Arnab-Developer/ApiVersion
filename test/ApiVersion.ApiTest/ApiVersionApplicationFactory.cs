using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;

namespace ApiVersion.ApiTest;

public class ApiVersionApplicationFactory : WebApplicationFactory<Program>
{
    protected override IHostBuilder CreateHostBuilder()
    {
        var builder = Host
            .CreateDefaultBuilder()
            .ConfigureWebHostDefaults(x =>
            {
                x.UseStartup<Program>().Configure(c => { });
            });

        return builder;
    }

    protected override IHost CreateHost(IHostBuilder builder)
    {
        //builder.ConfigureServices(services => { });

        //builder.ConfigureHostConfiguration(config => { });

        return base.CreateHost(builder);
    }
}