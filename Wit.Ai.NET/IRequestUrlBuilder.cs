#region Using Directives

using System.Collections.Generic;

#endregion

namespace Wit.Ai.NET
{
    public interface IRequestUrlBuilder
    {
        string Build(
            string apiEndPoint,
            IEnumerable<IParameter> parameters = null);
    }
}