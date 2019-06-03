using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands.UserCommands
{
    public class UserRegisterCommand
    {
        public UserRegisterCommand(string email, string username, string password)
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
