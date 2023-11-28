using Microsoft.AspNetCore.Mvc;
using Server.Models.Requests;
using Server.Models.Responses;
using Server.Services.Interfaces;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxController : ControllerBase
    {
        private readonly ITaxService _taxService;

        public TaxController(ITaxService taxService)
        {
            _taxService = taxService;
        }

        [HttpPost(Name = "calculate")]
        public TaxCalculateResponse Calculate(TaxCalculateRequest request)
        {
            var response = new TaxCalculateResponse();

            response.TaxAmount = _taxService.Calculate(request.Income, request.PostalCode);

            return response;
        }
    }
}
