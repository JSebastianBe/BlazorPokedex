using System;
using Newtonsoft.Json;
namespace BlazorPokedex.Models;

public class PokemonType
{
    [JsonProperty("name")]
    public string Name { get; set; }
}
