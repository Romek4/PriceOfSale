using NUnit.Framework;

namespace PriceOfSaleTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Barcode12345ReturnsPrice7dot95()
        {
            // arrange
            var barcode = "12345";
            var expectedResult = "Eur 7.95";

            // act
            var result = GetPrice(barcode);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Barcode99999ReturnsProductNotFound99999()
        {
            // arrange
            var barcode = "99999";
            var expectedResult = "Product not found: 99999";

            // act
            var result = GetPrice(barcode);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void EmptyBarcodeReturnsScanningErrorEmptyBarcode()
        {
            // arrange
            var barcode = "";
            var expectedResult = "Scanning error: empty barcode";

            // act
            var result = GetPrice(barcode);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        private string GetPrice(string barcode)
        {
            if (barcode == "12345")
            {
                return "Eur 7.95";
            }
            else if (barcode == "99999")
            {
                return $"Product not found: {barcode}";
            }
            
            return "Scanning error: empty barcode";
        }
    }
}