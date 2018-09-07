using System;
using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities.WitDurationEntity
{
    public class WitDurationEntity : Entity
    {
        public const string Name = "duration";

        [JsonProperty("normalized")]
        public DurationNormalized Normalized { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        public TimeSpan ToTimeSpan()
        {
            return TimeSpan.FromSeconds(Normalized.Value);
        }
    }
}