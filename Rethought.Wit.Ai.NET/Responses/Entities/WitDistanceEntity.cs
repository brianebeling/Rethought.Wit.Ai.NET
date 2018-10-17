using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitDistanceEntity : Entity
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("unit")] public string Unit { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}