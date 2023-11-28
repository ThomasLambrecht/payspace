using Moq;
using Server.Services;
using Server.Services.Factories.Interfaces;
using Server.Services.Interfaces;

namespace ServerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Flat_Rate_With_Income_200000_Use_10000()
        {
            var taxService = CreateTaxService();

            var taxAmount = taxService.Calculate(200000, Server.Models.TaxCalculationType.FlatRate);
            Assert.Equals(taxAmount, 10000.00);
        }

        [Test]
        public void When_Flat_Rate_With_Income_200001_Use_10000()
        {
            var taxService = CreateTaxService();

            var taxAmount = taxService.Calculate(200000, Server.Models.TaxCalculationType.FlatRate);
            Assert.Equals(taxAmount, 10000.00);
        }

        [Test]
        public void When_Flat_Rate_With_Income_199999_Use_5_Percent()
        {
            var taxService = CreateTaxService();

            var taxAmount = taxService.Calculate(200000, Server.Models.TaxCalculationType.FlatRate);
            Assert.Equals(taxAmount, 9999.95);
        }

        private ITaxService CreateTaxService()
        {
            var mockTaxCalculationTypeService = new Mock<TaxCalculationTypeService>().Object;
            var mockTaxCalculatorFactory = new Mock<ITaxCalculatorFactory>().Object;

            var taxService = new TaxService(mockTaxCalculationTypeService, mockTaxCalculatorFactory);
            return taxService;
        }

    }
}