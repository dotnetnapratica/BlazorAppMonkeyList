using BlazorAppMonkeyList.Models;
using System.Net.Http.Json;

namespace BlazorAppMonkeyList.Services
{
    public class MonkeyService : IMonkeyService
    {
        private readonly HttpClient httpClient;
        public MonkeyService(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient(nameof(MonkeyService));
        }

        public async Task<List<Monkey>> FindAll()
        {
            var result = await httpClient.GetFromJsonAsync<List<Monkey>>("monkeydata.json");

            return result;
        }
    }
}
