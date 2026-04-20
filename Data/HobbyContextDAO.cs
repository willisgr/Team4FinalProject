using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;

namespace Team4FinalProject.Data
{
    public class HobbyContextDAO : IHobbyContextDAO
    {
        private ApplicationDbContext _context;
        public HobbyContextDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        //Create
        public int? AddHobby(Hobby hobby)
        {
            var hobbies = _context.Hobbies.Where(x => x.HobbyName.Equals(hobby.HobbyName) && x.HobbyType.Equals(hobby.HobbyType)).FirstOrDefault();

            if (hobbies != null)
                return null;
            try
            {
                _context.Hobbies.Add(hobby);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        //Read
        public List<Hobby> GetAllHobbies()
        {
            return _context.Hobbies.ToList();
        }

        public Hobby GetHobbybyId(int id)
        {
            return _context.Hobbies.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        //Update
        public int? UpdateHobby(Hobby hobby)
        {
            var hobbyToUpdate = this.GetHobbybyId(hobby.Id);
            if (hobbyToUpdate == null)
                return null;
            hobbyToUpdate.HobbyName = hobby.HobbyName;
            hobbyToUpdate.HobbyType = hobby.HobbyType;
            hobbyToUpdate.YearsPracticed = hobby.YearsPracticed;
            hobbyToUpdate.IsExpensive = hobby.IsExpensive;

            try
            {
                _context.Hobbies.Update(hobbyToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Delete
        public int? RemoveHobbyById(int id)
        {
            var hobby = this.GetHobbybyId(id);
            if (hobby == null) return null;
            try
            {
                _context.Hobbies.Remove(hobby);
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