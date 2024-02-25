using FluentAssertions;
using Xunit;

namespace Katchr.Sales.Domain.Tests.Classes
{
    public class ItemTests
    {

        [Theory]
        [InlineData(1, 10.00, 1)]
        [InlineData(1, 20.00, 2)]
        [InlineData(1, 1.00, 0.1)]
        [InlineData(2, 1.00, 0.2)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0.1)]
        [InlineData(1, 18.99, 1.9)]

        public void Ensure_standard_item_correct_tax_calculated(
            int quantity,
            decimal price,
            decimal expectedTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new StandardItem(
                quantity, price, itemDef);

            //Act
            var result = item.SaleTax;

            //Assert
            result.Should().Be(expectedTax);
        }


        [Theory]
        [InlineData(1, 10.00, 11.0)]
        [InlineData(1, 20.00, 22.0)]
        [InlineData(1, 1.00, 1.1)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0.95)]
        [InlineData(1, 18.99, 20.89)]

        public void Ensure_standard_item_correct_price_inc_calculated(
            int quantity,
            decimal price,
            decimal expectedPriceIncTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new StandardItem(
                quantity, price, itemDef);

            //Act
            var result = item.SalePrice;

            //Assert
            result.Should().Be(expectedPriceIncTax);
        }


        [Theory]
        [InlineData(1, 10.00, 1.5)]
        [InlineData(1, 20.00, 3)]
        [InlineData(1, 1.00, 0.15)]
        [InlineData(2, 1.00, 0.3)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0.15)]
        [InlineData(1, 18.99, 2.85)]

        public void Ensure_imported_standard_item_correct_tax_calculated(
            int quantity,
            decimal price,
            decimal expectedTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new ImportedItem(new StandardItem(
                quantity, price, itemDef));

            //Act
            var result = item.SaleTax;

            //Assert
            result.Should().Be(expectedTax);
        }


        [Theory]
        [InlineData(1, 10.00, 11.5)]
        [InlineData(1, 20.00, 23)]
        [InlineData(1, 1.00, 1.15)]
        [InlineData(2, 1.00, 2.3)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 1)]
        [InlineData(1, 18.99, 21.84)]
        public void Ensure_imported_standard_item_correct_sale_price_calculated(
            int quantity,
            decimal price,
            decimal expectedSalePrice)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new ImportedItem(new StandardItem(
                quantity, price, itemDef));

            //Act
            var result = item.SalePrice;

            //Assert
            result.Should().Be(expectedSalePrice);
        }

        [Theory]
        [InlineData(1, 10.00, 0)]
        [InlineData(1, 20.00, 0)]
        [InlineData(1, 1.00, 0)]
        [InlineData(2, 1.00, 0)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0)]
        [InlineData(1, 18.99, 0)]

        public void Ensure_basic_tax_exempt_item_correct_tax_calculated(
          int quantity,
          decimal price,
          decimal expectedTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new BasicTaxExemptItem( 
                            new StandardItem(
                                quantity, price, itemDef));

            //Act
            var result = item.SaleTax;

            //Assert
            result.Should().Be(expectedTax);
        }


        [Theory]
        [InlineData(1, 10.00, 10)]
        [InlineData(1, 20.00, 20)]
        [InlineData(1, 1.00, 1)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0.85)]
        [InlineData(1, 18.99, 18.99)]

        public void Ensure_basic_tax_exempt_item_correct_price_inc_calculated(
            int quantity,
            decimal price,
            decimal expectedPriceIncTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new BasicTaxExemptItem(
                            new StandardItem(
                                quantity, price, itemDef));

            //Act
            var result = item.SalePrice;

            //Assert
            result.Should().Be(expectedPriceIncTax);
        }

        [Theory]
        [InlineData(1, 10.00, 0.5)]
        [InlineData(1, 20.00, 1)]
        [InlineData(1, 1.00, 0.05)]
        [InlineData(2, 1.00, 0.1)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0.05)]
        [InlineData(1, 18.99, 0.95)]
        public void Ensure_imported_basic_tax_exempt_item_correct_tax_calculated(
              int quantity,
              decimal price,
              decimal expectedTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item = new ImportedItem(
                           new BasicTaxExemptItem(
                                new StandardItem(
                                    quantity, price, itemDef)));

            //Act
            var result = item.SaleTax;

            //Assert
            result.Should().Be(expectedTax);
        }


        [Theory]
        [InlineData(1, 10.00, 10.5)]
        [InlineData(1, 20.00, 21)]
        [InlineData(1, 1.00, 1.05)]
        [InlineData(2, 1.00, 2.1)]
        [InlineData(0, 1.00, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0.85, 0.9)]
        [InlineData(1, 18.99, 19.94)]

        public void Ensure_imported_basic_tax_exempt_item_correct_price_inc_calculated(
            int quantity,
            decimal price,
            decimal expectedPriceIncTax)
        {

            var itemDef = new ItemDef();

            //Arrange
            var item =  new ImportedItem(
                           new BasicTaxExemptItem(
                                new StandardItem(
                                    quantity, price, itemDef)));

            //Act
            var result = item.SalePrice;

            //Assert
            result.Should().Be(expectedPriceIncTax);
        }



    }
}

