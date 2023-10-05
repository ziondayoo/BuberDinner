﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationServices : IAuthenticationServices
    {
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string token)
        {
            return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "token");
        }
    }
}