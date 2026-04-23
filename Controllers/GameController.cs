using Microsoft.AspNetCore.Mvc;
using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;


namespace Team4FinalProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class GameController : ControllerBase
	{
		private readonly ILogger<GameController> _logger;
		private readonly IGameContextDAO _context;
		public GameController(ILogger<GameController> logger, IGameContextDAO context)
		{
			_logger = logger;
			_context = context;
		}
        //Create
        [HttpPost]
        public IActionResult Post(Game game)
        {
            var result = _context.AddGame(game);

            if (result == null)
                return StatusCode(500, "Game already exists");
            if (result == 0)
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
            return Ok();
        }

        //Read
        [HttpGet]
		public IActionResult GetAllGames()
		{
			return Ok(_context.GetAllGames());
		}
		[HttpGet("id")]
		public IActionResult GetById(int id)
		{
            var game = _context.GetGamebyId(id);
            if (game == null || id == 0)
            {
                return Ok(_context.GetFirstFiveGames());
            }
            return Ok(game);
		}

		//Update
		[HttpPut]
		public IActionResult Put(Game game)
		{
            var result = _context.UpdateGame(game);
            if (result == null)
                return NotFound(game.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

		//Delete
        [HttpDelete]
		public IActionResult Delete(int id)
        {
			var result = _context.RemoveGameById(id);
            if (result == null )
                return NotFound(id);

			if (result == 0)
				return StatusCode(500, "An error occurred while processing your request");

			return Ok();

        }
    }
}