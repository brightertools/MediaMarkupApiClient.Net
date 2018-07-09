using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace MediaMarkup.Tests
{
    public class TestContextFixture : IDisposable
    {
        public IConfiguration Configuration { get; set; }
        
        public readonly IServiceProvider ServiceProvider;
        
        public IApiClient ApiClient { get; set; }

        public Settings Settings { get; set; }

        public Core.Tests.TestSettings TestSettings { get; set; }

        public string AccessToken { get; set; }

        public TestContextFixture()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile("testsettings.json", true, true)
                .Build();

            //IConfiguration configuration = builder.Build();

            //var settings = new Settings();

            // Setup DI for getting settings
            var services = new ServiceCollection();
            services.AddLogging();
            services.AddOptions();
            services.Configure<Settings>(Configuration.GetSection("MediaMarkup"));
            services.Configure<Core.Tests.TestSettings>(Configuration.GetSection("MediaMarkup"));
            services.AddMediaMarkup();
            ServiceProvider = services.BuildServiceProvider();

            Settings = ServiceProvider.GetService<IOptions<Settings>>().Value;

            TestSettings = ServiceProvider.GetService<IOptions<Core.Tests.TestSettings>>().Value;
        }

        public void Dispose()
        {
            // ... clean up
        }
    }
}
