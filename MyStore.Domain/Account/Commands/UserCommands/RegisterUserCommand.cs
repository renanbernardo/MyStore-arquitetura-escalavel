﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore.Domain.Account.Commands.UserCommands
{
    public class RegisterUserCommand
    {
        public RegisterUserCommand(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
