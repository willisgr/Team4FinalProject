using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface ILanguageContextDAO
    {
        //Create
        bool CreateLanguage(Language language);

        //Read
        Language? GetLanguageByIdOrDefault(int id);
        List<Language> GetFirstFiveLanguages();

        //Update
        bool UpdateLanguageById(int id, Language updatedLanguage);

        //Delete
        bool DeleteLanguageById(int id);
    }
}