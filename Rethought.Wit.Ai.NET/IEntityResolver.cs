using System.Collections.Generic;
using Optional;
using Wit.Ai.NET.Responses;
using Wit.Ai.NET.Responses.Entities;

namespace Wit.Ai.NET
{
    public interface IEntityResolver
    {
        Option<IReadOnlyCollection<T>> GetEntity<T>(MessageResponse messageResponse, string name) where T : Entity;
    }
}