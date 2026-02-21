using Binding_Lab.Properties;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Text;

namespace Binding_Lab.Resourse
{
    public class MyLoc : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler CurrentLanguageChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        private static readonly ResourceManager ResourceManager = Resources.ResourceManager;

        private static MyLoc _instance;
        public static MyLoc Instance => _instance ??= new MyLoc();

        private MyLoc() { }

        public string this[string key] => ResourceManager.GetString(key, Thread.CurrentThread.CurrentUICulture);

        // Метод смены языка
        public void ChangeLanguage(string cultureName)
        {
            var culture = new CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = culture;

            CurrentLanguageChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }
    }
}
