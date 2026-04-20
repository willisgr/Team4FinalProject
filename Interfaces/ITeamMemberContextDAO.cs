using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface ITeamMemberContextDAO
    {
        // return true if success
        bool CreateTeamMember(TeamMember teamMember);
        TeamMember? GetTeamMemberByIdOrDefault(int id);
        List<TeamMember> GetFirstFiveTeamMembers();
        bool UpdateTeamMemberById(int id, TeamMember updatedTeamMember);
        bool DeleteTeamMemberById(int id);
    }
}