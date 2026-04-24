using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team4FinalProject.Data;
using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;

namespace Team4FinalProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageContextDAO _context;
        private readonly ILogger<LanguageController> _logger;

        public LanguageController(ILanguageContextDAO context, ILogger<LanguageController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Create
        [HttpPost]
        public IActionResult Post([FromBody] Language language)
        {
            if (_context.CreateLanguage(language)) { return Created(); }
            return BadRequest();
        }

        // Read
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var language = _context.GetLanguageByIdOrDefault(id);
            if (language == null) { return Ok(_context.GetFirstFiveLanguages()); }
            return Ok(language);
        }

        // Update
        [HttpPut("id")]
        public IActionResult Put(int id, [FromBody] Language language)
        {
            if (_context.UpdateLanguageById(id, language)) { return Ok(); }
            return BadRequest();
        }

        // Delete
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            if (_context.DeleteLanguageById(id)) { return NoContent(); }
            return BadRequest();
        }
    }
}