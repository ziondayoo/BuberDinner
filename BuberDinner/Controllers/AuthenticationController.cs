using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationServices _authenticationServices;

        public AuthenticationController(IAuthenticationServices authenticationServices)
        {
            _authenticationServices = authenticationServices;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {
            var  authResult = _authenticationServices.Register(request.FirstName,request.LastName, request.Email, request.Password);

            var response = new AuthenticationResponse(authResult.Id, authResult.FirstName, authResult.LastName, authResult.Email, authResult.Token);
            return Ok(response);
        }
        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationServices.Login(request.Email, request.Password);
            var response = new AuthenticationResponse(authResult.Id, authResult.FirstName, authResult.LastName, authResult.Email, authResult.Token);
             return Ok(response);

        }
    }
}
      