namespace Katchr.Sales;

/// <summary>
/// A service that builds a sale basket based on the 
/// input to parsed.
/// </summary>
public class BasketBuilder(
    IInputParser inputParser,
    ITaxExemptChecker taxExemptChecker,
    IItemDefRepository itemDefRepository)
{

    private readonly IInputParser _inputParser = inputParser;
    private readonly ITaxExemptChecker _taxExcemptChecker = taxExemptChecker;
    private readonly IItemDefRepository _itemDefRepository = itemDefRepository;

    public Basket Build(string input)
    {
        var basket = new Basket();

        foreach (InputItem inputItem in _inputParser.Parse(input))
        {

            ItemDef itemDef = _itemDefRepository.GetItemDefByName(inputItem.Name);

            Item item = new StandardItem(
                inputItem.Quantity,
                inputItem.Price,
                itemDef);

            if (_taxExcemptChecker.IsExempt(item.ItemDef.ItemType))
            {
                item = new BasicTaxExemptItem(item);
            }

            if (inputItem.IsImported)
            {
                item = new ImportedItem(item);
            }

            basket.AddItem(item);
        }

        return basket;

    }
}

