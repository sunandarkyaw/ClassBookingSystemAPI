using Core.Entities.InputModels;
using Core.Entities.Models;

namespace BookingService.Manager.Interface
{
    public interface IUserManager
    {
        string GenerateJwtToken(LoginInfo userName, string jwtkey, string jwtIssueer, string jwtAudience);
        AuthorizeUserInfo GetUser(LoginInfo userInfo);
    }
}
