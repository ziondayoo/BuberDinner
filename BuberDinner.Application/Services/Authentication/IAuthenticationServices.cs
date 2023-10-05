﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public interface IAuthenticationServices
    {
        AuthenticationResult Login(string email, string password);
        AuthenticationResult Register(string firstName, string lastName, string email, string password);
    }
}
