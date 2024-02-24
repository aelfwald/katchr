
using Katchr.Sales;

var saleProcessor = new SaleProcessor(
                        new BasketBuilder(
                                new InputParser(),
                                new TaxExemptChecker(),
                                new ItemDefRepository()
                                ));

var printer = new ConsoleReceiptPrinter();

string input1 =
            @"1 Book at 12.49 
1 Music CD at 14.99
1 Chocolate bar at 0.85";

string input2 = 
            @"1 Imported box of chocolates at 10.00 
1 Imported bottle of perfume at 47.50 ";

string input3 = @"1 Imported bottle of perfume at 27.99
1 Bottle of perfume at 18.99 1 Packet of paracetamol at 9.75
1 Box of imported chocolates at 11.2";


//Input 1
Console.WriteLine("");
Console.WriteLine("Press any key to process input 1...");
Console.ReadKey();
Console.WriteLine("Input 1:");
Console.WriteLine(input1);
Console.WriteLine("");

Console.WriteLine("Output 1:");
saleProcessor.Process(
        input1,
        printer
    );

//Input 2
Console.WriteLine("");
Console.WriteLine("Press any key to process input 2...");
Console.ReadKey();
Console.WriteLine("");
Console.WriteLine("Input 2:");
Console.WriteLine(input2);
Console.WriteLine("");

Console.WriteLine("Output 2:");
saleProcessor.Process(
        input2,
        printer
    );

//Input 3
Console.WriteLine("");
Console.WriteLine("Press any key to process input 3...");
Console.ReadKey();
Console.WriteLine("");
Console.WriteLine("Input 3:");
Console.WriteLine(input3);
Console.WriteLine("");
Console.WriteLine("Output 3:");
saleProcessor.Process(
        input3,
        printer);

Console.WriteLine("");
Console.WriteLine("Press any key to exit");
Console.ReadKey();

Environment.Exit(0);