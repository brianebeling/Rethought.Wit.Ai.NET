using System.Threading.Tasks;
using Rethought.Wit.Ai.NET.Responses;

namespace Rethought.Wit.Ai.NET
{
    public interface INaturalLanguageProcessor
    {
        Task<MessageResponse> GetMeaning(string input);
    }
}