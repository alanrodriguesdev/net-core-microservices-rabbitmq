using Domain.Models;
using Newtonsoft.Json;

namespace Infrastructure.Parsers
{
    public class JsonParser : IJsonParser
    {
        public List<List<Operations>>? Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            string adjustedInput = $"[{input.Replace("][", "],[")}]";

            return JsonConvert.DeserializeObject<List<List<Operations>>>(adjustedInput);
        }

       
    }
}
