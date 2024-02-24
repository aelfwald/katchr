
namespace Katchr.Sales;

public interface IInputParser
{
    IEnumerable<InputItem> Parse(string input);
}
