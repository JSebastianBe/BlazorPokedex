using System;
using Newtonsoft.Json;

namespace BlazorPokedex.Models;

public class Pokemon
{
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("types")]
    public List<Type> Types { get; set; }
    [JsonProperty("sprites")]
    public Sprite Sprites { get; set; }
}
