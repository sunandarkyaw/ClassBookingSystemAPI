using Interface.Interfaces;
using Repository.Helper;
using System.Data;
using Dapper;
using Core.Entities.Models;
using Core.Entities.InputModels;

namespace Repository.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private IDatabaseConnectionFactory _connectionFactory;
        public BookingRepository(IDatabaseConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<List<ScheduleInfo>> GetALLScheduleList(ScheduleListInput listInput)
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.createConnection("ClassBookingDB"))
                {
                    List<ScheduleInfo> responseData = (await conn.QueryAsync<ScheduleInfo>("SP_GetScheduleList",
                    new
                    {
                        @countryID = listInput.countryID
                    },
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

        public async Task<List<PackageInfo>> GetALLPackageList()
        {
            try
            {
                using (IDbConnection conn = _connectionFactory.createConnection("ClassBookingDB"))
                {
                    List<PackageInfo> responseData = (await conn.QueryAsync<PackageInfo>("SP_GetPurchaseList",
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

        public async Task<CodeMessage> BookingClass(BookingInput info)
        {
            CodeMessage responseData = new CodeMessage();
            try
            {
                using (IDbConnection conn = _connectionFactory.createConnection("ClassBookingDB"))
                {
                    responseData = conn.Query<CodeMessage>("SP_BookingSchedule",
                    new
                    {
                        @classID = info.classID,
                        @userID = info.userID
                    },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
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

        public async Task<CodeMessage> CancelBooking(CancelInput info)
        {
            CodeMessage responseData = new CodeMessage();
            try
            {
                using (IDbConnection conn = _connectionFactory.createConnection("ClassBookingDB"))
                {
                    responseData = conn.Query<CodeMessage>("SP_CancelBooking",
                    new
                    {
                        @bookingID = info.bookingID
                    },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
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
