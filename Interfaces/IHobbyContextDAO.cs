using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface IHobbyContextDAO
    {
        //Create
        int? AddHobby(Hobby hobby);

        //Read
        List<Hobby> GetAllHobbies();
        Hobby GetHobbybyId(int id);
		List<Hobby> GetFirstFiveHobbies();

        
        // Update
        int? UpdateHobby(Hobby hobby);

        // Delete
        int? RemoveHobbyById(int id);
    }
}