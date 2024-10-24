namespace Interface.Interfaces
{
    public interface IBookingRepository
    {
        Task<List<string>> GetScheduleList();
    }
}
