using AutoMapper;
using Library.Models.Identity;
using Library.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bonkers.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/Authorize")]
    public class AuthController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signinManager;

        public AuthController(IConfiguration config, IMapper mapper, UserManager<User> userManager, SignInManager<User> signinManager)
        {
            _config = config;
            _mapper = mapper;
            _userManager = userManager;
            _signinManager = signinManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            User user = await _userManager.FindByNameAsync(dto.UserName);
            var result = await _signinManager.CheckPasswordSignInAsync(user, dto.Password, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                Response.CreateToken(_config);
                return Ok(user);
            }
            else return Unauthorized("Invalid credentials");
        }
    }
}
