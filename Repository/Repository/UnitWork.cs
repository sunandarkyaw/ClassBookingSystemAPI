using Interface.Interfaces;

namespace Repository.Repository
{
    internal class UnitWork : IUnitWork
    {
        public IBookingRepository _iBookingRepository { get; }

        public UnitWork(IBookingRepository bookingRepository)
        {
            _iBookingRepository = bookingRepository;
        }
    }
}
