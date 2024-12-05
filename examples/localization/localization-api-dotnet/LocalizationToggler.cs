using Godot;

public partial class LocalizationToggler : Button
{
	private int _languageIndex = 0;

	private new void ButtonUp()
	{
		var languages = TranslationServer.GetLoadedLocales();
		ChangeLanguage(languages[_languageIndex]);
		_languageIndex = _languageIndex == (languages.Length - 1) ? 0 : (_languageIndex + 1);
	}
	
	private void ChangeLanguage(string languageIso)
	{
		TranslationServer.SetLocale(languageIso);
		GD.Print("In Game Language: " + TranslationServer.GetLocale());
	}
}
