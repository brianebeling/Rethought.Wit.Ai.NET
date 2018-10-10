using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Wit.Ai.NET.Responses
{
    public class MessageResponse
    {
        [JsonProperty("entities")]
        public IDictionary<string, IReadOnlyList<JObject>> Entities { get; set; } =
            new Dictionary<string, IReadOnlyList<JObject>>();

        [JsonProperty("msg_id")] public string MessageId { get; set; }

        [JsonProperty("_text")] public string Text { get; set; }

        public IReadOnlyList<JObject> GetIntents()
        {
            return Entities.TryGetValue("intent", out var value) ? value : null;
        }
    }
}