using System.Configuration;
using System.Data;
using System.Windows;
using CodingSeb.Localization;
using CodingSeb.Localization.Loaders;
using System.Diagnostics;

namespace Binding_Lab
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Loc.Instance.LogOutMissingTranslations = true;

            LocalizationLoader.Instance.FileLanguageLoaders.Add(new JsonFileLoader());
            LocalizationLoader.Instance.AddDirectory("Locales");

            Loc.Instance.CurrentLanguage = "ru";

            var loadedLanguages = Loc.Instance.AvailableLanguages;
            Debug.WriteLine($"Загруженные языки: {string.Join(", ", loadedLanguages)}");
        }
    }

}
