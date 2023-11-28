using Server.Models;
using Server.Services.Calculators.Interfaces;
using Server.Services.Factories.Interfaces;

namespace Server.Services.Factories
{
    public class TaxCalculatorFactory : ITaxCalculatorFactory
    {
        private readonly IFlatValueTaxCalculator _flatValueTaxCalculator;
        private readonly IFlatRateTaxCalculator _flatRateTaxCalculator;
        private readonly IProgressiveTaxCalculator _progressiveTaxCalculator;

        public TaxCalculatorFactory(IFlatValueTaxCalculator flatValueTaxCalculator, IFlatRateTaxCalculator flatRateTaxCalculator, IProgressiveTaxCalculator progressiveTaxCalculator)
        {
            _flatValueTaxCalculator = flatValueTaxCalculator;
            _flatRateTaxCalculator = flatRateTaxCalculator;
            _progressiveTaxCalculator = progressiveTaxCalculator;
        }

        public ITaxCalculator GetTaxCalculator(TaxCalculationType taxCalculationType)
        {
            switch (taxCalculationType)
            {
                case TaxCalculationType.FlatValue:
                    return _flatValueTaxCalculator;
                case TaxCalculationType.FlatRate:
                    return _flatRateTaxCalculator;
                case TaxCalculationType.Progressive:
                    return _progressiveTaxCalculator;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
