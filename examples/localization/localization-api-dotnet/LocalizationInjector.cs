using Godot;
using System.Linq;
using Godot.Collections;

public partial class LocalizationInjector : Button
{
	private new void ButtonUp()
	{
		const string languageIso = "lv";

		if (TranslationServer.GetLoadedLocales().Contains(languageIso))
		{
			GD.Print($"Locale: {languageIso} already loaded");
			return;
		}
		
		var translation = new Translation { Locale = languageIso };
		var dict = new Dictionary<string, string>
		{
			{"BALANCE", "SOME LATVIAN SHIT"}
		};
		
		foreach (var keyValuePair in dict)
		{
			translation.AddMessage(keyValuePair.Key, keyValuePair.Value);
		}
		TranslationServer.AddTranslation(translation);
		TranslationServer.SetLocale(languageIso);
	}
}
