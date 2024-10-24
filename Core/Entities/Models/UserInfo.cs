using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string Email { get; set; }
        public decimal Credit { get; set; }
    }
}
