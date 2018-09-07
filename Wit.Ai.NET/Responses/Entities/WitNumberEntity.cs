using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitNumberEntity : Entity
    {
        public static readonly string Name = "number";

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }
}