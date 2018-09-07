using System.Collections.Generic;
using System.Linq;
using Optional;
using Wit.Ai.NET.Responses;
using Wit.Ai.NET.Responses.Entities;

namespace Wit.Ai.NET
{
    public class EntityResolver : IEntityResolver
    {
        public Option<IReadOnlyCollection<T>> GetEntity<T>(MessageResponse messageResponse, string name)
            where T : Entity
        {
            return messageResponse.Entities.TryGetValue(name, out var discordUsers)
                ? Option.Some<IReadOnlyCollection<T>>(discordUsers.Select(x => x.ToObject<T>()).ToList())
                : Option.None<IReadOnlyCollection<T>>();
        }
    }
}