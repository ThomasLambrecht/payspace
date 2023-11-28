namespace Server.Models.Requests
{
    public class TaxCalculateRequest
    {
        public decimal Income { get; set; }
        public string PostalCode { get; set; }
    }
}
