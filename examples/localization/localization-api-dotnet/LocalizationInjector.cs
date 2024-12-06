using System.Linq;
using Godot;
using Godot.Collections;

namespace LocalizationAPIDotNet;

/// <summary>
/// <para>Fetches Latvian translations from a server and injects it into the game</para>
/// <para>Docs: https://docs.godotengine.org/en/stable/tutorials/networking/http_request_class.html</para>
/// </summary>
public partial class LocalizationInjector : Button
{
	private const string LanguageIso = "lv";

	private new void ButtonUp()
	{

		if (TranslationServer.GetLoadedLocales().Contains(LanguageIso))
		{
			GD.Print($"Locale: {LanguageIso} already loaded");
			return;
		}

		var httpRequest = GetParent().GetNode<HttpRequest>("HTTPRequest");
		httpRequest.RequestCompleted += OnRequestCompleted;
		// TODO replace this with the endpoint that will return translations for your desired language iso
		httpRequest.Request("https://api.github.com/repos/godotengine/godot/releases/latest");
	}
	
	private static void OnRequestCompleted(long result, long responseCode, string[] headers, byte[] body)
	{
		// var json = Json.ParseString(Encoding.UTF8.GetString(body)).AsGodotDictionary();
		// GD.Print(json["name"]);
		
		var translation = new Translation { Locale = LanguageIso };
		var dict = new Dictionary<string, string>
		{
			{"BALANCE", "Something in Latvian"}
		};
		
		foreach (var keyValuePair in dict)
		{
			translation.AddMessage(keyValuePair.Key, keyValuePair.Value);
		}
		TranslationServer.AddTranslation(translation);
		TranslationServer.SetLocale(LanguageIso);
	}
}