using Server.Models;
using Server.Models.Requests;
using Server.Models.Responses;

namespace Server.Services.Interfaces
{
    public interface ITaxService
    {
        //public TaxCalculateResponse Calculate(TaxCalculateRequest request);

        public decimal Calculate(decimal income, string postalCode);
        public decimal Calculate(decimal income, TaxCalculationType taxCalculationType);
    }
}
