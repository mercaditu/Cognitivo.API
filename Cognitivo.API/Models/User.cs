﻿using System;
namespace Cognitivo.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string Passcode { get; set; }
        public string ApiKey { get; set; }
    }
}
