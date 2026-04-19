using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;

namespace Team4FinalProject.Data
{
    public class GameContextDAO : IGameContextDAO
    {
        private ApplicationDbContext _context;
        public GameContextDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Game> GetAllGames()
        {
            return _context.Games.ToList();
        }

        public Game GetGamebyId(int id)
        {
            return _context.Games.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveGameById(int id)
        {
            var game = this.GetGamebyId(id);
            if (game == null) return null;
            try
            {
                _context.Games.Remove(game);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? UpdateGame(Game game)
        {
            var gameToUpdate = this.GetGamebyId(game.Id);
            if (gameToUpdate == null)
                return null;
            gameToUpdate.Title = game.Title;
            gameToUpdate.Developer = game.Developer;
            gameToUpdate.Genre = game.Genre;
            gameToUpdate.Price = game.Price;

            try
            {
                _context.Games.Update(gameToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}