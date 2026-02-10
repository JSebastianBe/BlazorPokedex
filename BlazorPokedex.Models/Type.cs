using System;
using Newtonsoft.Json;

namespace BlazorPokedex.Models;

public class Type
{
    [JsonProperty("slot")]
    public int Slot { get; set; }
    [JsonProperty("type")]
    public PokemonType Types { get; set; }
}
