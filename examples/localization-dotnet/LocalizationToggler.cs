using Godot;
using System;
using System.Collections.Generic;

public partial class LocalizationToggler : Button
{
	private int _languageIndex = 1;
	private readonly List<string> _languages = new() {"en", "es"};
	
	public new void ButtonUp() {
		ChangeLanguage(_languages[_languageIndex]);
		_languageIndex = (_languageIndex + 1) % _languages.Count;
	}
	
	
	
	private void ChangeLanguage(string languageIso)
	{
		TranslationServer.SetLocale(languageIso);
	}
}
