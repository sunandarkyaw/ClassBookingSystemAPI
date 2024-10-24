using Interface.Interfaces;
using Repository.Helper;
using System.Data;
using Dapper;

namespace Repository.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private IDatabaseConnectionFactory _connectionFactory;
        public BookingRepository(IDatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<String>> GetScheduleList()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.createConnection("DatabaseConnections.SSBISContributions"))
                {
                    List<String> responseData = (await conn.QueryAsync<String>("spGetOustandingListByER",                    
                    commandType: CommandType.StoredProcedure)).ToList();

                    return responseData;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _connectionFactory.closeConnection("DatabaseConnections.SSBISContributions");
            }
        }

    }
}
