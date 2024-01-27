using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace SeleniumBasic.Utilites.Configuration
{
    public static class Configurator
    {
        private static readonly Lazy<IConfiguration> SConfiguration;
        private static IConfiguration Configuration => SConfiguration.Value;

        static Configurator()
        {
            SConfiguration = new Lazy<IConfiguration>(BuildConfiguration);
        }

        private static IConfiguration BuildConfiguration()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var builder = new ConfigurationBuilder()
                .SetBasePath(basePath ?? throw new InvalidOperationException())
                .AddJsonFile("appsettings.json");

            var appSettingFiles = Directory.EnumerateFiles(basePath ?? string.Empty, "appsettings.*.json");

            foreach (var appSettingFile in appSettingFiles)
            {
                builder.AddJsonFile(appSettingFile);
            }

            return builder.Build();
        }

        public static AppSettings AppSettings
        {
            get
            {
                var appSettings = new AppSettings();
                var child = Configuration.GetSection("AppSettings");

                appSettings.Url = child["URL"];

                return appSettings;
            }
        }

        public static string? BrowserType => Configuration[nameof(BrowserType)];
    }
}