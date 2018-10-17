using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public abstract class Entity
    {
        [JsonProperty("confidence")] public double Confidence { get; set; }
    }
}