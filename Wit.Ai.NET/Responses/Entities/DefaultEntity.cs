using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public abstract class DefaultEntity : Entity
    {
        [JsonProperty("suggested")]
        public bool Suggested { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}