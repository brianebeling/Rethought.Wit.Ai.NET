using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class CommonEntity : Entity
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("value")] public string Value { get; set; }
    }
}