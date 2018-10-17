using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitBye : Entity
    {
        [JsonProperty("value")] public bool Value { get; set; }
    }
}