using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitAiIntent : Entity
    {
        [JsonProperty("value")] public string Value { get; set; }
    }
}