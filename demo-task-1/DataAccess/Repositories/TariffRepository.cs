using System.Collections.Generic;
using DemoTask1.DataAccess.Models;
using DemoTask1.DataAccess.Repositories.Interfaces;

namespace DemoTask1.DataAccess.Repositories
{
    public class TariffRepository : ITariffRepository
    {
        public IEnumerable<BaseTariff> GetAllTariffs()
        {
            return new BaseTariff[]
                   {new BasicTariff {Name = "Basic Tariff"}, new PackagedTariff {Name = "Packaged Tariff"}};
        }
    }
}