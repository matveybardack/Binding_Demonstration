using Binding_Lab.Properties;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Text;
using System.Windows;
using System.Windows.Resources;

namespace Binding_Lab.Resourse
{
    public static class LocalizationManager
    {
        private static ResourceDictionary _currentDictionary;

        public static void ChangeLanguage(string cultureCode)
        {
            try
            {
                // путь к словарю
                string dictionaryPath = $"Resourse/Languages/StringResources.{cultureCode}.xaml";

                Uri resourceUri = new Uri(dictionaryPath, UriKind.Relative);

                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = resourceUri;

                ReplaceApplicationDictionary(newDictionary, cultureCode);

                LocalizationService.Instance.LanguageChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading language: {ex.Message}");
            }
        }

        private static void ReplaceApplicationDictionary(ResourceDictionary newDictionary, string cultureCode)
        {
            var appDictionaries = Application.Current.Resources.MergedDictionaries;

            // Ищем и удаляем старый локализованный словарь
            for (int i = appDictionaries.Count - 1; i >= 0; i--)
            {
                var dict = appDictionaries[i];
                if (dict.Source != null && dict.Source.OriginalString.Contains("StringResources."))
                {
                    appDictionaries.RemoveAt(i);
                    break;
                }
            }

            appDictionaries.Add(newDictionary);
        }
    }

    public class LocalizationService : INotifyPropertyChanged
    {
        private static LocalizationService _instance;
        public static LocalizationService Instance => _instance ??= new LocalizationService();

        public event PropertyChangedEventHandler? PropertyChanged;

        public string this[string key]
        {
            get
            {
                var resource = Application.Current.TryFindResource(key);
                return resource?.ToString() ?? $"[{key}]";
            }
        }

        public void LanguageChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }
    }
}
