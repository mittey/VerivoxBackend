using System.Collections.Generic;
using DemoTask1.DataAccess.Models;

namespace DemoTask1.Services.Interfaces
{
    public interface ITariffComparerService
    {
        IEnumerable<CompareResult> Compare(int consumption);
    }
}