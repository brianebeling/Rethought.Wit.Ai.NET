#region Using Directives

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Wit.Ai.NET.Responses;

#endregion

namespace Wit.Ai.NET
{
    public class WitAiClient : INaturalLanguageProcessor
    {
        private readonly IRequestUrlBuilder builder;
        private readonly HttpClient httpClient;

        private WitAiClient(HttpClient httpClient, IRequestUrlBuilder builder)
        {
            this.httpClient = httpClient;
            this.builder = builder;
        }

        public static WitAiClient Create(HttpClient httpClient, string token, string version = "20170307")
        {
            var client = new WitAiClient(
                httpClient,
                new RequestUrlBuilder(
                    ApiEndPoints.BaseUrl,
                    new List<IParameter>
                    {
                        new Parameter("v", version)
                    }));

            httpClient.BaseAddress = new Uri(ApiEndPoints.BaseUrl);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            return client;
        }

        public async Task<MessageResponse> GetMeaning(string message, bool verbose)
        {
            //if (message.Length < 1 || message.Length >= 256) return null;

            var request = await Request<MessageResponse>(
                builder.Build(
                    ApiEndPoints.Message, new List<IParameter> {new Parameter("q", message)}));

            return request;
        }

        public async Task<MessageResponse> GetMeaning(string message)
        {
            //if (message.Length < 1 || message.Length >= 256) return null;

            var request = await Request<MessageResponse>(
                builder.Build(
                    ApiEndPoints.Message, new List<IParameter> {new Parameter("q", message)}));

            return request;
        }


        private async Task<T> Request<T>(string request)
        {
            var respone = await httpClient.GetAsync(request);

            var responseText = await respone.Content.ReadAsStringAsync();

            Console.WriteLine(responseText);

            return JsonConvert.DeserializeObject<T>(responseText);
        }
    }
}