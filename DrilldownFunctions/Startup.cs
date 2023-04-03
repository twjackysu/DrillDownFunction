using DrilldownFunctions.Common.Factory;
using DrilldownFunctions.Data;
using DrilldownFunctions.Functions.AzureCosmosDB;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using NLog.Extensions.Logging;
using System.IO;

[assembly: FunctionsStartup(typeof(DrilldownFunctions.Startup))]
namespace DrilldownFunctions
{
    public class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
            FunctionsHostBuilderContext context = builder.GetContext();

            var config = builder.ConfigurationBuilder
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, "appsettings.json"), optional: true, reloadOnChange: false)
                .AddJsonFile(Path.Combine(context.ApplicationRootPath, $"appsettings.{context.EnvironmentName}.json"), optional: true, reloadOnChange: false)
                .AddEnvironmentVariables();
        }
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var configuration = builder.GetContext().Configuration;

            builder.Services.AddOptions();
            builder.Services.Configure<AppSettings>(configuration.GetSection("AppSettings"));

            builder.Services.AddDbContext<DrilldownDbContext>(
                options => options.UseCosmos(
                    configuration.GetConnectionString("CosmosDb"),
                    configuration.GetValue<string>("CosmosDb:DatabaseName")), ServiceLifetime.Singleton, ServiceLifetime.Singleton);

            LogManager.Setup().LoadConfigurationFromSection(configuration);
            builder.Services.AddLogging((loggingBuilder) =>
            {
                var nlogOptions = new NLogProviderOptions()
                {
                    ShutdownOnDispose = true,
                    RemoveLoggerFactoryFilter = true
                };
                loggingBuilder.AddNLog(nlogOptions);
            });

            builder.Services.AddSingleton<AzureCosmosDBFactory>();
            builder.Services.AddSingleton<IApiResponseFactory, ApiResponseFactory>();
            builder.Services.AddSingleton<IResponseFactory, ResponseFactory>();
        }
    }
}
