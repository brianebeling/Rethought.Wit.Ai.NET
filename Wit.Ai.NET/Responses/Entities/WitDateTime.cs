using System;
using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitDateTime : Entity
    {
        [JsonProperty("grain")] public string Grain { get; set; }

        [JsonProperty("value")] public DateTime Value { get; set; }
    }
}