﻿namespace Core.Entities.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public string Email { get; set; }
        public decimal Credit { get; set; }
    }

    public class AuthorizeUserInfo : UserInfo
    {
        public string token { get; set; }
    }
}
