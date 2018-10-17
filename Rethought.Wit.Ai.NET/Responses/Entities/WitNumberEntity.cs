using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitNumberEntity : Entity
    {
        public const string Name = "number";

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}