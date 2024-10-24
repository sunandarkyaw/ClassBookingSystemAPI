using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.InputModels
{
    public class LoginInfo
    {
        public string userCode { get; set; }
        public string password { get; set; }
    }

    public class RegisterInfo : LoginInfo
    {
        public string userName { get; set; }
        public decimal userCredit { get; set; }
    }

    public class UserInputInfo
    {
        public string userID { get; set; }
        public string password { get;set; }
    }
}
