using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectControl.Models;
using ProjectControl.Context;

namespace ProjectControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly ContextDb _context;

        public ProfileController(ILogger<ProfileController> logger,
                                 ContextDb context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Profile> Get()
        {
            return _context.Profile.ToList();
        }
    }
}