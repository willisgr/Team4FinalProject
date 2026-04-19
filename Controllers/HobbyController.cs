using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Team4FinalProject.Models;
using Team4FinalProject.Data;


namespace Team4FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : ControllerBase
    {
        private readonly ILogger<HobbyController> _logger;
        private readonly ApplicationDbContext _context;
        public HobbyController(ILogger<HobbyController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Hobbies.ToList());
        }

        /*	
			[HttpPost]

			[HttpPut]
		*/
        [HttpDelete]
        public IActionResult Delete(int Id) 
        {
            var game = _context
        }

    }
}