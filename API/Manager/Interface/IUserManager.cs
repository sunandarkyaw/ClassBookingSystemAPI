namespace BookingService.Manager.Interface
{
    public interface IUserManager
    {
        string GenerateJwtToken(string userName);
    }
}
