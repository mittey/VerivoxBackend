namespace DemoTask1.DataAccess.Models
{
    public abstract class BaseTariff
    {
        public string Name { get; set; }
        public abstract int GetAnnualCosts(int consumption);
    }
}