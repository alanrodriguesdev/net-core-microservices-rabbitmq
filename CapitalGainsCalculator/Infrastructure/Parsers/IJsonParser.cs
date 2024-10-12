using Domain.Models;

namespace Infrastructure.Parsers
{
    public interface IJsonParser
    {
        List<List<Operations>>? Parse(string input);
    }
}
