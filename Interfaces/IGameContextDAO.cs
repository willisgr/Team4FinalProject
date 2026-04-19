using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface IGameContextDAO
    {
        List<Game> GetAllGames();
        Game GetGamebyId(int id);
        int? RemoveGameById(int id);
        int? UpdateGame(Game game);
    }
}