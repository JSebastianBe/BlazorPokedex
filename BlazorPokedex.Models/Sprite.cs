using System;
using Newtonsoft.Json;

namespace BlazorPokedex.Models;

public class Sprite
{
    [JsonProperty("front_default")]
    public string FrontDefault { get; set; }
    [JsonProperty("back_default")]
    public string BackDefault { get; set; }
}
