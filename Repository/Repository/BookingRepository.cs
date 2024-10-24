using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class BookingRepository : IBookingRepository
    {
        public BookingRepository() { }

        public List<String> GetScheduleList()
        {
            return new List<String>();
        }

    }
}
