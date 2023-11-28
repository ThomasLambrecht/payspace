using Server.Models;

namespace Server.Services.Interfaces
{
    public interface ITaxCalculationTypeService
    {
        public TaxCalculationType GetTaxCalculationTypeFromPostalCode(string postalCode);
    }
}
