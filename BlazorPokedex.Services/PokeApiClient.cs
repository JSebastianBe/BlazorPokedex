using System;
using Newtonsoft.Json;
using BlazorPokedex.Models;

namespace BlazorPokedex.Services;

public class PokeApiClient : IPokeApiClient
{
    private readonly HttpClient _httpClient;
    public PokeApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<Pokemon> GetPokemon(string name)
    {
        return JsonConvert.DeserializeObject<Pokemon>(
            await _httpClient.GetStringAsync($"pokemon/{name}"));
    }

    public async Task<ResultObject> GetAllPokemons(PaginationParameter parameters)
    {
        return JsonConvert.DeserializeObject<ResultObject>(
            await _httpClient.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.Offset}"));

    }
}
