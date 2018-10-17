using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities.WitDurationEntity
{
    public class DurationNormalized : Entity
    {
        [JsonProperty("unit")] public string Unit { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}