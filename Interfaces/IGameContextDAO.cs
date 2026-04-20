using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface IGameContextDAO
    {
        //Create
        int? AddGame(Game game);

        //Read
        List<Game> GetAllGames();
        Game GetGamebyId(int id);

        
        // Update
        int? UpdateGame(Game game);

        // Delete
        int? RemoveGameById(int id);


    }
}