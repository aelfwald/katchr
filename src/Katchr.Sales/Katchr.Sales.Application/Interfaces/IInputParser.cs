
namespace Katchr.Sales;

/// <summary>
/// Defines service that parses input when processing a sale.
/// </summary>
public interface IInputParser
{
    IEnumerable<InputItem> Parse(string input);
}
