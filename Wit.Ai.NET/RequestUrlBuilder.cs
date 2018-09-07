#region Using Directives

using System.Collections.Generic;
using System.Linq;

#endregion

namespace Wit.Ai.NET
{
    public class RequestUrlBuilder : IRequestUrlBuilder
    {
        private readonly string baseAdress;

        private readonly IEnumerable<IParameter> reoccuringParameters;

        public RequestUrlBuilder(
            string baseAdress,
            IEnumerable<IParameter> reoccuringParameters)
        {
            this.baseAdress = baseAdress;
            this.reoccuringParameters = reoccuringParameters;
        }

        public string Build(
            string apiEndPoint,
            IEnumerable<IParameter> parameters = null)
        {
            var value = baseAdress + apiEndPoint;

            var @params = new List<IParameter>();

            if (reoccuringParameters != null)
                @params.AddRange(reoccuringParameters);

            if (parameters != null)
                @params.AddRange(parameters);

            var first = @params.First();

            value += "?" + first.Get();

            @params.Remove(first);

            var aggregate = @params.Aggregate(
                value,
                (current, param) => current + "&" + param.Get());

            return aggregate;
        }
    }
}