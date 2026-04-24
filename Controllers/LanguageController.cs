using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team4FinalProject.Data;
using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;


namespace Team4FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LanguageController : ControllerBase
    {
        private readonly ILogger<LanguageController> _logger;
        private readonly ILanguageContextDAO _context;
        public LanguageController(ILogger<LanguageController> logger, ILanguageContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        //Create
        [HttpPost]
        public IActionResult Post([FromBody] Language language)
        {
            if (_context.CreateLanguage(language)) { return Created(); }
            return BadRequest();
        }

        //Read
        [HttpGet]
        public IActionResult Get(int id)
        {
            var language = _context.GetLanguageByIdOrDefault(id);
            if (language == null) { return Ok(_context.GetFirstFiveLanguages()); }
            return Ok(language);
        }

        //Update
        [HttpPut]
        public IActionResult Put(int id, [FromBody] Language language)
        {
            if (_context.UpdateLanguageById(id, language)) { return Ok(); }
            return BadRequest();
        }

        //Delete
        [HttpDelete]
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            if (_context.DeleteLanguageById(id)) { return NoContent(); }
            return BadRequest();
        }
    }
}