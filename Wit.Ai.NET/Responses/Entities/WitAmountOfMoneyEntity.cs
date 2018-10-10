using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitAmountOfMoneyEntity : DefaultEntity
    {
        [JsonProperty("unit")] public string Unit { get; set; }

        [JsonProperty("value")] public long Value { get; set; }
    }
}