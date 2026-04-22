using Team4FinalProject.Models;

namespace Team4FinalProject.Interfaces
{
    public interface ILanguageContextDAO
    {
        //Create
        int? AddLanguage(Language language);

        //Read
        List<Language> GetAllLanguages();
        Language GetLanguagebyId(int id);


        // Update
        int? UpdateLanguage(Language language);

        // Delete
        int? RemoveLanguageById(int id);
    }
}