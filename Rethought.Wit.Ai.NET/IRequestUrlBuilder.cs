#region Using Directives

using System.Collections.Generic;

#endregion

namespace Rethought.Wit.Ai.NET
{
    public interface IRequestUrlBuilder
    {
        string Build(
            string apiEndPoint,
            IEnumerable<IParameter> parameters = null);
    }
}