using System.Globalization;
using System.Text.RegularExpressions;

namespace Katchr.Sales;

/// <summary>
/// Parses input to the sales process.
/// </summary>
public class InputParser : IInputParser
{
    public IEnumerable<InputItem> Parse(string input)
    {

        var regEx = new Regex("(\\d+) ([A-Za-z ]*) at (\\d+.\\d+)[ ]?");

        MatchCollection matches = regEx.Matches(input);

        foreach (var match in matches.Cast<Match>())
        {
            int quantity = int.Parse(match.Groups[1].Value);
            string name = match.Groups[2].Value;
            bool isImported = name.ToLower().Contains("imported", StringComparison.OrdinalIgnoreCase);
            decimal price = decimal.Parse(match.Groups[3].Value, NumberStyles.Currency);

            yield return new InputItem()
            {
                IsImported = isImported,
                Name = name.Trim(),
                Quantity = quantity,
                Price = price
            };
        }
    }
}
