﻿using System.ComponentModel.DataAnnotations;

namespace StyleX.DTOs
{
    public class LoginModel
    {
        public string email { get; set; }
        public string password { get; set; }
    }
    public class UserModel
    {
        public string? fullName { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string? phoneNumber { get; set; } = string.Empty;
        public string? address { get; set; } = string.Empty;

    }
}
