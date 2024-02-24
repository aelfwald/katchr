namespace Katchr.Sales;

public class BasketBuilder(
    IInputParser inputParser,
    ITaxExcemptChecker taxExcemptChecker,
    IItemDefRepository itemDefRepository)
{

    private readonly IInputParser _inputParser = inputParser;
    private readonly ITaxExcemptChecker _taxExcemptChecker = taxExcemptChecker;
    private readonly IItemDefRepository _itemDefRepository = itemDefRepository;

    public Basket Build(string input)
    {
        var basket = new Basket();

        foreach (InputItem inputItem in _inputParser.Parse(input))
        {

            ItemDef itemDef = _itemDefRepository.GetItemDefByName(inputItem.Name);

            IItem item = new Item(
                inputItem.Quantity,
                inputItem.Price,
                itemDef,
                new TaxCalc());

            if (_taxExcemptChecker.IsExcempt(item.ItemDef.ItemType))
            {
                item = new BasicTaxExcemptItem(item);
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

