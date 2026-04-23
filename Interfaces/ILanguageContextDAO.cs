using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface ILanguageContextDAO
    {
        //Create
        int? AddLanguage(Language language);

        //Read
        Language? GetLanguagebyId(int id);
        List<Language> GetAllLanguages();
		List<Language> GetFirstFiveLanguages();

        // Update
        int? UpdateLanguage(Language language);

        // Delete
        int? RemoveLanguageById(int id);
    }
}