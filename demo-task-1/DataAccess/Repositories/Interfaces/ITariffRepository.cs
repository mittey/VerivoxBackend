using System.Collections.Generic;
using DemoTask1.DataAccess.Models;

namespace DemoTask1.DataAccess.Repositories.Interfaces
{
    public interface ITariffRepository
    {
        IEnumerable<BaseTariff> GetAllTariffs();
    }
}