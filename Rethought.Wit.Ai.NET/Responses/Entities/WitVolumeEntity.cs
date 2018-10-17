using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitVolumeEntity : Entity
    {
        public const string Name = "volume";

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("unit")] public string Unit { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}