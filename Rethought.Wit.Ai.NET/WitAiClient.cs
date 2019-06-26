#region Using Directives

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rethought.Wit.Ai.NET.Responses;

#endregion

namespace Rethought.Wit.Ai.NET
{
    internal class ApiClient
    {
        private readonly IRequestUrlBuilder builder;
        private readonly HttpClient httpClient;

        private ApiClient(HttpClient httpClient, IRequestUrlBuilder builder)
        {
            this.httpClient = httpClient;
            this.builder = builder;
        }

        public static ApiClient Create(HttpClient httpClient, string token, string version = "20170307")
        {
            httpClient.BaseAddress = new Uri(ApiEndPoints.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            var apiClient = new ApiClient(
                httpClient,
                new RequestUrlBuilder(
                    ApiEndPoints.BaseUrl,
                    new List<IParameter>
                    {
                        new Parameter("v", version)
                    }));

            return apiClient;
        }

        public async Task<T> Request<T>(Func<IRequestUrlBuilder, string> requestBuilder)
        {
            var response = await httpClient.GetAsync(requestBuilder.Invoke(builder)).ConfigureAwait(false);

            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            Console.WriteLine(responseText);

            return JsonConvert.DeserializeObject<T>(responseText);
        }
    }

    public class WitAiClient
    {
        private WitAiClient(WitAiTrainingClient witAiTrainingClient)
        {
            this.Training = witAiTrainingClient;
        }

        public WitAiTrainingClient Training { get; }

        public static WitAiClient Create(HttpClient httpClient, string token, string version = "20170307")
        {
            var apiClient = ApiClient.Create(httpClient, token, version);

            return new WitAiClient(new WitAiTrainingClient(apiClient));
        }
    }

    public class WitAiTrainingClient : INaturalLanguageProcessor
    {
        private readonly ApiClient apiClient;

        internal WitAiTrainingClient(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public async Task<MessageResponse> GetMeaning(string message)
        {
            //if (message.Length < 1 || message.Length >= 256) return null;

            var request = await apiClient.Request<MessageResponse>(
                builder => builder.Build(
                    ApiEndPoints.Message,
                    new List<IParameter> {new Parameter("q", message)})).ConfigureAwait(false);

            return request;
        }

        public async Task<MessageResponse> GetMeaning(string message, bool verbose)
        {
            // TODO Verbose
            //if (message.Length < 1 || message.Length >= 256) return null;

            var request = await apiClient.Request<MessageResponse>(
                builder => builder.Build(
                    ApiEndPoints.Message,
                    new List<IParameter> {new Parameter("q", message)})).ConfigureAwait(false);

            return request;
        }
    }
}