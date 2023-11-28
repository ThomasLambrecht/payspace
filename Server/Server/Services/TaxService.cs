using Server.Models;
using Server.Models.Requests;
using Server.Models.Responses;
using Server.Services.Factories;
using Server.Services.Factories.Interfaces;
using Server.Services.Interfaces;

namespace Server.Services
{
    public class TaxService : ITaxService
    {
        private readonly ITaxCalculationTypeService _taxCalculationTypeService;
        private readonly ITaxCalculatorFactory _taxCalculatorFactory;

        public TaxService(ITaxCalculationTypeService taxCalculationTypeService, ITaxCalculatorFactory taxCalculatorFactory)
        {
            _taxCalculationTypeService = taxCalculationTypeService;
            _taxCalculatorFactory = taxCalculatorFactory;
        }

        //public TaxCalculateResponse Calculate(TaxCalculateRequest request)
        //{
        //    var response = new TaxCalculateResponse();

        //    var taxCalculationType = _taxCalculationTypeService.GetTaxCalculationTypeFromPostalCode(request.PostalCode);
        //    var taxCalculator = _taxCalculatorFactory.GetTaxCalculator(taxCalculationType);
        //    response.TaxAmount = taxCalculator.Calculate(request.Income);

        //    return response;
        //}

        public decimal Calculate(decimal income, string postalCode)
        {
            throw new NotImplementedException();
        }
        
        public decimal Calculate(decimal income, TaxCalculationType taxCalculationType)
        {
            throw new NotImplementedException();
        }

    }
}
