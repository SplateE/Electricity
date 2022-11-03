using Electricity.Entities;

namespace Electricity.Contracts
{
    public interface ILastToMonthData
    {
        public Task<IEnumerable<LastTwoMonths>> GetLastTwoMonthData();
    }
}
