namespace DemoTask1.DataAccess.Models
{
    public class PackagedTariff : BaseTariff
    {
        private const int AdditionalConsumptionPricePerKwh = 30;
        private const int BasicConsumption = 4000;
        private const int BasicPrice = 80000;

        public override int GetAnnualCosts(int consumption)
        {
            if (consumption <= BasicConsumption)
            {
                return BasicPrice;
            }

            var additionalConsumption = consumption - BasicConsumption;
            var additionalPrice = additionalConsumption * AdditionalConsumptionPricePerKwh;
            return BasicPrice + additionalPrice;
        }
    }
}