﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.Identity
{
    public class UserRegisterDTO
    {
        [Required, MinLength(4)]
        public string UserName { get; set; }
        [Required, MinLength(6)]
        public string Password { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }

    }
}