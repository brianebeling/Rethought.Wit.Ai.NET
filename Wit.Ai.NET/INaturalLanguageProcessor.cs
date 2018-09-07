using System.Threading.Tasks;
using Wit.Ai.NET.Responses;

namespace Wit.Ai.NET
{
    public interface INaturalLanguageProcessor
    {
        Task<MessageResponse> GetMeaning(string input);
    }
}