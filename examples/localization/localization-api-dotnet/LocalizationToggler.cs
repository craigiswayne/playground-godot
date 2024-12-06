using Godot;

namespace LocalizationAPIDotNet;

public partial class LocalizationToggler : Button
{
	// Order of the way translations are preloaded matter here
	// see the project.godot file
	// the default language shown is english
	// then once clicked it will switch to index 1 in the array described in
	// project.godot
	private int _languageIndex = 1;

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