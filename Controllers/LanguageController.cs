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
        // Still needs work?
        [HttpPost]
        public IActionResult Post(Language language)
        {
            var result = _context.AddLanguage(language);

            if (result == null)
                return StatusCode(500, "Language already exists");
            if (result == 0)
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
            return Ok();
        }

        //Read
        [HttpGet]
        public IActionResult GetLanguages()
        {
            return Ok(_context.GetAllLanguages());
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var language = _context.GetLanguagebyId(id);
            {
            if (language == null || id == 0)
                return Ok(_context.GetFirstFiveLanguages());
			}
            return Ok(language);
        }

        //Update
        [HttpPut]
        public IActionResult Put(Language language)
        {
            var result = _context.UpdateLanguage(language);
            if (result == null)
                return NotFound(language.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        //Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveLanguageById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();

        }
    }
}