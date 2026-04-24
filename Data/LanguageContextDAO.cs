using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace Team4FinalProject.Data
{
    public class LanguageContextDAO : ILanguageContextDAO
    {
        private ApplicationDbContext _context;
        public LanguageContextDAO(ApplicationDbContext context)
        {
            _context = context;
        }

        //Create
        public bool CreateLanguage(Language language)
        {
            try
            {
                _context.Languages.Add(language);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Read
        public Language? GetLanguageByIdOrDefault(int id)
        {
            if (id == 0) { return null; }
            return _context.Languages.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public List<Language> GetFirstFiveLanguages()
        {
            return _context.Languages.Take(5).ToList();
        }

        //Delete
        public bool DeleteLanguageById(int id)
        {
            var language = _context.Languages.FirstOrDefault(x => x.Id == id);
            if (language == null) return false;

            try
            {
                _context.Languages.Remove(language);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Update
        public bool UpdateLanguageById(int id, Language updatedLanguage)
        {
            var language = _context.Languages.FirstOrDefault(x => x.Id == id);
            if (language == null) return false;

            language.Name = updatedLanguage.Name ?? language.Name;
            language.Type = updatedLanguage.Type != default ? updatedLanguage.Type : language.Type;
            language.IsStronglyTyped = updatedLanguage.IsStronglyTyped = language.IsStronglyTyped;
            language.IsCompiled = updatedLanguage.IsCompiled = language.IsCompiled;

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