using System.Globalization;
using System.Text.RegularExpressions;

namespace Katchr.Sales;

public class InputParser : IInputParser
{
    public IEnumerable<InputItem> Parse(string input)
    {

        var regEx = new Regex("(\\d+) ([A-Za-z ]*) at (\\d+.\\d+)[ ]?");

        MatchCollection matches = regEx.Matches(input);

        foreach (var match in matches.Cast<Match>())
        {
            int quantity = int.Parse(match.Groups[1].Value);
            string description = match.Groups[2].Value;
            bool isImported = description.ToLower().Contains("imported", StringComparison.OrdinalIgnoreCase);
            decimal price = decimal.Parse(match.Groups[3].Value, NumberStyles.Currency) + 0.00M;

            yield return new InputItem()
            {
                IsImported = isImported,
                Name = description.ToLower().Replace("imported ", "").Trim(),
                Quantity = quantity,
                Price = price
            };
        }
    }
}
