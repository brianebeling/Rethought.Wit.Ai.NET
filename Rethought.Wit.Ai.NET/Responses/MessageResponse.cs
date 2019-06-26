using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rethought.Optional;
using Rethought.Wit.Ai.NET.Responses.Entities;

namespace Rethought.Wit.Ai.NET.Responses
{
    public class MessageResponse
    {
        [JsonProperty("entities")]
        public IDictionary<string, IReadOnlyList<JObject>> Entities { get; set; } =
            new Dictionary<string, IReadOnlyList<JObject>>();

        [JsonProperty("msg_id")]
        public string MessageId { get; set; }

        [JsonProperty("_text")]
        public string Text { get; set; }

        public Option<IReadOnlyList<WitAiIntent>> GetIntents()
        {
            return this.GetEntities<WitAiIntent>("intent");
        }

        public Option<IReadOnlyList<T>> GetEntities<T>(string name)
            where T : Entity
        {
            return this.Entities.TryGetValue(name, out var entities)
                ? entities.Select(x => x.ToObject<T>()).ToList().Some<IReadOnlyList<T>>()
                : default;
        }
    }
}