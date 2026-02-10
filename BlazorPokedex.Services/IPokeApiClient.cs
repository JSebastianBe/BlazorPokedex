using System;
using BlazorPokedex.Models;

namespace BlazorPokedex.Services;

public interface IPokeApiClient
{
    Task<ResultObject> GetAllPokemons(PaginationParameter parameters);
    Task<Pokemon> GetPokemon(string name);
}
