using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface IGameContextDAO
    {
        //Create
        int? AddGame(Game game);

        //Read
        Game? GetGamebyId(int id);
        List<Game> GetAllGames();
        List<Game> GetFirstFiveGames();

        // Update
        int? UpdateGame(Game game);

        // Delete
        int? RemoveGameById(int id);


    }
}