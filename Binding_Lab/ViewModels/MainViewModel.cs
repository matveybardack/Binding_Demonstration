global using System.ComponentModel;
global using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Binding_Lab.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<TabItemViewModel> Tabs { get; } = [];

        [ObservableProperty]
        private ObservableCollection<string> _availableLanguages = ["en", "ru"];

        [ObservableProperty]
        private string _selectedLanguage = "en";

        partial void OnSelectedLanguageChanged(string value)
        {
            // Смена языка
        }

        private void UpdateTabHeaders()
        {
            foreach (var tab in Tabs)
            {
                // Обновление заголовков
            }
        }

        public MainViewModel()
        {
            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabDefault",
                Header = "TabDefault",
                ContentViewModel = new DefaultBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabTwoWay",
                Header = "TabTwoWay",
                ContentViewModel = new TwoWaysBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabOneTime",
                Header = "TabOneTime",
                ContentViewModel = new OneTimeBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabOneWay",
                Header = "TabOneWay",
                ContentViewModel = new OneWayBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabTriggers",
                Header = "TabTriggers",
                ContentViewModel = new TriggersViewModel()
            });
        }
    }

    public partial class TabItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _header;
        public string LocalizationKey { get; set; }
        public object ContentViewModel { get; set; }
    }
}