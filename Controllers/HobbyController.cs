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
    public class HobbyController : ControllerBase
    {
        private readonly ILogger<HobbyController> _logger;
        private readonly IHobbyContextDAO _context;
        public HobbyController(ILogger<HobbyController> logger, IHobbyContextDAO context)
        {
            _logger = logger;
            _context = context;
        }

        //Create
        // Still needs work?
        [HttpPost]
        public IActionResult Post(Hobby hobby)
        {
            var result = _context.AddHobby(hobby);

            if (result == null)
                return StatusCode(500, "Hobby already exists");
            if (result == 0)
            {
                return StatusCode(500, "An error occurred while processing your request");
            }
            return Ok();
        }

        //Read
        [HttpGet]
        public IActionResult GetAllHobbies()
        {
            return Ok(_context.GetAllHobbies());
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var hobby = _context.GetHobbybyId(id);
            if (hobby == null || id == 0)
                return NotFound(id);
            return Ok(hobby);
        }

        //Update
        [HttpPut]
        public IActionResult Put(Hobby hobby)
        {
            var result = _context.UpdateHobby(hobby);
            if (result == null)
                return NotFound(hobby.Id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();
        }

        //Delete
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _context.RemoveHobbyById(id);
            if (result == null)
                return NotFound(id);

            if (result == 0)
                return StatusCode(500, "An error occurred while processing your request");

            return Ok();

        }
    }
}