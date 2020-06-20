using Bonkers.Data;
using Library.Models.Identity;
using Library.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bonkers.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/Users")]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> _context;
        private readonly IConfiguration _config;

        public UsersController(UserManager<User> context, IConfiguration config)
        {
            _context = context;
            _config = config;
            _config = config;
        }

        [HttpGet("Raw")]
        public async Task<IActionResult> GetRawUserData()
        {
            var result = await _context.Users.ToListAsync();
            Response.CreateToken(_config);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _context.Users.ToListAsync();
            Response.CreateToken(_config);
            return Ok(result);
        }
    }
}
