namespace Spike.Ambassador.Api.V2.Helpers
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;

    public static class SpikeAmbassadorHttpClient
    {
        public static HttpClient GetClient()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(ApplicationSettings.InternalApiBaseUrl)
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}