using System;
using Newtonsoft.Json;

namespace BlazorPokedex.Models;

public class ResultObject
{
    [JsonProperty("count")]
    public int Count { get; set; }
    [JsonProperty("next")]
    public string Next { get; set; }
    [JsonProperty("previous")]
    public string Previous { get; set; }
    [JsonProperty("results")]
    public IEnumerable<Pokemon> Pokemons { get; set; }
}
