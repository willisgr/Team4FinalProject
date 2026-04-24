using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace Team4FinalProject.Data
{
    public class TeamMemberContextDAO : ITeamMemberContextDAO {
        private ApplicationDbContext _context;
        public TeamMemberContextDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        //Create
        public bool CreateTeamMember(TeamMember teamMember)
        {
            try
            {
                _context.TeamMembers.Add(teamMember);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Read
        public TeamMember? GetTeamMemberByIdOrDefault(int id)
        {
            if (id == 0) {return null;}
            return _context.TeamMembers.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public List<TeamMember> GetFirstFiveTeamMembers()
        {
            return _context.TeamMembers.Take(5).ToList();
        }

        //Delete
        public bool DeleteTeamMemberById(int id)
        {
            var teamMember = _context.TeamMembers.FirstOrDefault(x => x.Id == id);
            if (teamMember == null) return false;
            
            try
            {
                _context.TeamMembers.Remove(teamMember);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Update
        public bool UpdateTeamMemberById(int id, TeamMember updatedTeamMember)
        {
            var teamMember = _context.TeamMembers.FirstOrDefault(x => x.Id == id);
            if (teamMember == null) return false;
            
            teamMember.FullName = updatedTeamMember.FullName ?? teamMember.FullName;
            teamMember.Birthdate = updatedTeamMember.Birthdate != default ? updatedTeamMember.Birthdate : teamMember.Birthdate;
            teamMember.CollegeProgram = updatedTeamMember.CollegeProgram ?? teamMember.CollegeProgram;
            teamMember.YearInProgram = updatedTeamMember.YearInProgram ?? teamMember.YearInProgram;
            
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}