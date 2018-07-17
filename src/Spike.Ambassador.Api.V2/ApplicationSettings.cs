namespace Spike.Ambassador.Api.V2
{
    using System;
    using Microsoft.Extensions.Configuration;

    public static class ApplicationSettings
    {
        public static string ApiBaseUrl { get; }
        public static string InternalApiBaseUrl { get; }
        
        static ApplicationSettings()
        {
            var settingsResolver = GetSettingsResolver();
            ApiBaseUrl = settingsResolver("Spike.Ambassador.Api.BaseUrl");
            InternalApiBaseUrl = settingsResolver("Spike.Ambassador.Internal.Api.BaseUrl");
        }

        private static Func<string, string> GetSettingsResolver()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            var configuration = configurationBuilder.Build();

            return (name) => configuration.GetSection(name).Value;
        }
    }
}