namespace Rethought.Wit.Ai.NET
{
    public class Parameter : IParameter
    {
        public Parameter(string keyword, string value)
        {
            Keyword = keyword;
            Value = value;
        }

        public string Keyword { get; set; }

        public string Value { get; set; }

        public string Get()
        {
            return $"{Keyword}={Value}";
        }
    }
}