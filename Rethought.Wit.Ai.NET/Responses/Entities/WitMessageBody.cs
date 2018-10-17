using Newtonsoft.Json;

namespace Rethought.Wit.Ai.NET.Responses.Entities
{
    public class WitMessageBody : DefaultEntity
    {
        public static readonly string Name = "messagebody";

        [JsonProperty("body")] public string Body { get; set; }


        [JsonProperty("value")] public string Value { get; set; }
    }
}