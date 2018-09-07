using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Wit.Ai.NET.Responses.Entities
{
    public class WitDateTimeEntity : Entity
    {
        [JsonProperty("grain")]
        public string Grain { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public DateTime Value { get; set; }

        [JsonProperty("values")]
        public List<WitDateTimeEntity> Values { get; set; }
    }
}