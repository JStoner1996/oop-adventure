namespace OOPAdventure;

// Singleton class to manage the current language for text output
public static class Text
{

    private static Language _language;

    public static Language Language
    {
        // Get the current language, throw an exception if not loaded
        get
        {
            if (_language == null)
            {
                throw new Exception("Language not loaded. Please load a language before accessing text.");
            }

            return _language;
        }
    }

    public static void LoadLanguage(Language language)
    {
        _language = language;
    }
}
