using System.Collections.Generic;
using System.Linq;
using DemoTask1.DataAccess.Models;
using DemoTask1.DataAccess.Repositories.Interfaces;
using DemoTask1.Services.Interfaces;

namespace DemoTask1.Services
{
    public class TariffComparerService : ITariffComparerService
    {
        private readonly ITariffRepository _tariffRepository;

        public TariffComparerService(ITariffRepository tariffRepository)
        {
            _tariffRepository = tariffRepository;
        }

        public IEnumerable<CompareResult> Compare(int consumption)
        {
            var tariffs = _tariffRepository.GetAllTariffs();

            return tariffs.Select(tariff => new CompareResult
                {Name = tariff.Name, AnnualCosts = tariff.GetAnnualCosts(consumption)}).AsEnumerable();
        }
    }
}