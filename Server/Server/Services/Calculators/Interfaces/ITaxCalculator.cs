namespace Server.Services.Calculators.Interfaces
{
    public interface ITaxCalculator
    {
        decimal Calculate(decimal income);
    }
}
