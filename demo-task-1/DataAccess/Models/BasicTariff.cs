namespace DemoTask1.DataAccess.Models
{
    public class BasicTariff : BaseTariff
    {
        private const int PricePerKwh = 22;
        private const int PricePerYear = 6000;

        public override int GetAnnualCosts(int consumption)
        {
            return PricePerYear + consumption * PricePerKwh;
        }
    }
}