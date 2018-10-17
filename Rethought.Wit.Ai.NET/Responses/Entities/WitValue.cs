using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitValue
    {
        [JsonProperty("value")] public string Value { get; set; }
    }
}