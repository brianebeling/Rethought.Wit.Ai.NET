using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitDateTimeRangeEntity : Entity
    {
        [JsonProperty("to")] public WitDateTime To { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("values")] public List<WitDateTimeRangeEntity> Values { get; set; }

        [JsonProperty("from")] public WitDateTime WitDateTime { get; set; }
    }
}