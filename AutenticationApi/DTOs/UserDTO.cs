﻿using System;

namespace AutenticationApi.DTOs
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public Guid Id { get; set; }
    }
}
