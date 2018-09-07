namespace Wit.Ai.NET
{
    public class Parameter : IParameter
    {
        public string Keyword { get; set; }

        public string Value { get; set; }

        public Parameter(string keyword, string value)
        {
            Keyword = keyword;
            Value = value;
        }

        public string Get()
        {
            return $"{Keyword}={Value}";
        }
    }
}