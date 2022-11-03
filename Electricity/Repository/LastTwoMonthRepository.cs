using Dapper;
using Electricity.Context;
using Electricity.Contracts;
using Electricity.Entities;
using static Electricity.Repository.LastTwoMonthRepository;

namespace Electricity.Repository
{
    public class LastTwoMonthRepository : ILastToMonthData
    {

        private readonly LastTwoMonthContext _context;

        public LastTwoMonthRepository(LastTwoMonthContext context)
            {
                _context = context;
            }

        public async Task<IEnumerable<LastTwoMonths>> GetLastTwoMonthData()
        {
            var query = "SELECT * FROM [Test].[dbo].[LastTwoMonths] s where s.OBT_PAVADINIMAS ='Butas'";
            using (var connection = _context.CreateConnection())
            {
                var Butas = await connection.QueryAsync<LastTwoMonths>(query);
                return Butas.ToList();
            }

        }

    }
}
