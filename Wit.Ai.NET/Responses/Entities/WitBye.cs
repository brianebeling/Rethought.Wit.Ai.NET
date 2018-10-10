using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitBye : Entity
    {
        [JsonProperty("value")] public bool Value { get; set; }
    }
}