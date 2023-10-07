using BuberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationServices : IAuthenticationServices
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationServices(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }
        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // Check if user already exist;
            // Create user(generate unique ID)
            // Create JWT Token

            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            return new AuthenticationResult(userId, firstName, lastName, email, token);
        }

        public AuthenticationResult Login(string email, string password)
        {
           

            return new AuthenticationResult(Guid.NewGuid(), "firstName", "lastName", email, "token");
        }

    }
}
