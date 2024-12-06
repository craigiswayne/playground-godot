using Godot;
using System.Collections.Generic;

public partial class LocalizationToggler : Button
{
	private int _languageIndex = 0;
	private string[] _languages;
	
	public override void _Ready()
	{
		_languages = TranslationServer.GetLoadedLocales();
		base._Ready();
	}

	private new void ButtonUp()
	{
		ChangeLanguage(_languages[_languageIndex]);
		_languageIndex = (_languageIndex + 1) % _languages.Count;
	}
	
	private void ChangeLanguage(string languageIso)
	{
		TranslationServer.SetLocale(languageIso);
	}
}
