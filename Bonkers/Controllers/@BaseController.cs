using Bonkers.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bonkers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BaseController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public BaseController(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
    }
}
