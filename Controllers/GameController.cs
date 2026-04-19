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
	public class GameController : ControllerBase
	{
		private readonly ILogger<GameController> _logger;
		private readonly ApplicationDbContext _context;
		public GameController(ILogger<GameController> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_context.Games.ToList());
		}

        /*	
			[HttpPost]

			[HttpPut]
		*/
        [HttpDelete]
        public IActionResult Delete(int id)
        {
			var game = _context.GetGameById(id);
        }
    }
}