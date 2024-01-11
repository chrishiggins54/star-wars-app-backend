using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsApp_API.Services
{
    public class StarWarsService
    {
        private readonly HttpClient _httpClient;

        public StarWarsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetCharactersAsync()
        {
            var response = await _httpClient.GetAsync("https://swapi.dev/api/people/");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SearchCharactersAsync(string name)
        {
            var response = await _httpClient.GetAsync($"https://swapi.dev/api/people/?search={name}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCharacterDetailAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://swapi.dev/api/people/{id}/");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

    }
}
