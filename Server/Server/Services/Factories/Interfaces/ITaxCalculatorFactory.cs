using Server.Models;
using Server.Services.Calculators.Interfaces;

namespace Server.Services.Factories.Interfaces
{
    public interface ITaxCalculatorFactory
    {
        public ITaxCalculator GetTaxCalculator(TaxCalculationType taxCalculationType);
    }
}
