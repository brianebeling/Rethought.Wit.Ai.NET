using System.Collections.Generic;
using Optional;
using Rethought.Wit.Ai.NET.Responses;
using Rethought.Wit.Ai.NET.Responses.Entities;

namespace Rethought.Wit.Ai.NET
{
    public interface IEntityResolver
    {
        Option<IReadOnlyCollection<T>> GetEntity<T>(MessageResponse messageResponse, string name) where T : Entity;
    }
}