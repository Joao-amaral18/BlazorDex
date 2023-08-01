using System.Net;
using System.Text.Json;
using BlazorDex.Models;

namespace BlazorDex.Utils
{
    public class PokeClient
    {
        public HttpClient Client { get; set; }
        public PokeClient(HttpClient client)
        {
            this.Client = client;
        }
        public async Task<Pokemon> GetPokemonAsync(string id)
        {

            var response = await Client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");
            var content = await response.Content.ReadAsStringAsync();
            Pokemon? pokemon = JsonSerializer.Deserialize<Pokemon>(content);

            if (pokemon == null)
                return new ErrorObject("Pokémon not found");

            return pokemon;
        }
    }

    internal class ErrorObject : Pokemon
    {
        private string errorMessage;

        public ErrorObject(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }
    }
}