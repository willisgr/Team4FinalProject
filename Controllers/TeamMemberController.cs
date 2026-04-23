using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team4FinalProject.Data;
using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;

namespace Team4FinalProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TeamMembersController : ControllerBase
    {
        private readonly ITeamMemberContextDAO _context;
        private readonly ILogger<TeamMembersController> _logger;

        public TeamMembersController( ITeamMemberContextDAO context, ILogger<TeamMembersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Create
        [HttpPost]
        public IActionResult Post([FromBody]TeamMember teamMember)
        {
            if (_context.CreateTeamMember(teamMember)) {return Created();}
            return BadRequest();
        }

        // Read
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var teamMember = _context.GetTeamMemberByIdOrDefault(id);
            if (teamMember == null) {return Ok(_context.GetFirstFiveTeamMembers());}
            return Ok(teamMember);
        }

        // Update
        [HttpPut("id")]
        public IActionResult Put(int id, [FromBody]TeamMember teamMember)
        {
            if (_context.UpdateTeamMemberById(id, teamMember)) {return Ok();}
            return BadRequest();
        }

        // Delete
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            if (_context.DeleteTeamMemberById(id)) {return NoContent();}
            return BadRequest();
        }
    }
}