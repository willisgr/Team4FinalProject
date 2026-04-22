using Team4FinalProject.Interfaces;
using Team4FinalProject.Models;

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
        public int? AddLanguage(Language language)
        {
            var languages = _context.Languages.Where(x => x.Name.Equals(language.Name) && x.Type.Equals(language.Type)).FirstOrDefault();

            if (languages != null)
                return null;
            try
            {
                _context.Languages.Add(language);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        //Read
        public List<Language> GetAllLanguages()
        {
            return _context.Languages.ToList();
        }

        public Language GetLanguagebyId(int id)
        {
            return _context.Languages.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        //Update
        public int? UpdateLanguage(Language language)
        {
            var languageToUpdate = this.GetLanguagebyId(language.Id);
            if (languageToUpdate == null)
                return null;
            languageToUpdate.Name = language.Name;
            languageToUpdate.Type = language.Type;
            languageToUpdate.IsCompiled = language.IsCompiled;
            languageToUpdate.IsStronglyTyped = language.IsStronglyTyped;

            try
            {
                _context.Languages.Update(languageToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        // Delete
        public int? RemoveLanguageById(int id)
        {
            var language = this.GetLanguagebyId(id);
            if (language == null) return null;
            try
            {
                _context.Languages.Remove(language);
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