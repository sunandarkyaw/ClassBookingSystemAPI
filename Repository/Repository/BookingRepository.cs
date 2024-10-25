using Interface.Interfaces;
using Repository.Helper;
using System.Data;
using Dapper;
using Core.Entities.Models;

namespace Repository.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private IDatabaseConnectionFactory _connectionFactory;
        public BookingRepository(IDatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<ScheduleInfo>> GetScheduleList()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.createConnection("ClassBookingDB"))
                {
                    List<ScheduleInfo> responseData = (await conn.QueryAsync<ScheduleInfo>("SP_GetScheduleList",                    
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
                _connectionFactory.closeConnection("ClassBookingDB");
            }
        }

    }
}
