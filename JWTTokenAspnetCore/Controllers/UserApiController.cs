using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTTokenAspnetCore.Interface;
using JWTTokenAspnetCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenAspnetCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserApiController : ControllerBase
    {
        private IUserService _userService;

        public UserApiController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate(User user)
        {
            var _user = _userService.Authenticate(user.Username, user.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(_user.Token);
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}