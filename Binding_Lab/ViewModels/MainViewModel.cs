global using System.ComponentModel;
global using System.Runtime.CompilerServices;
using CodingSeb.Localization;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Binding_Lab.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<TabItemViewModel> Tabs { get; } = [];
        public ObservableCollection<string> AvailableLanguages { get; } = Loc.Instance.AvailableLanguages;

        [ObservableProperty]
        private string _selectedLanguage;

        public MainViewModel()
        {
            _selectedLanguage = Loc.Instance.CurrentLanguage;

            if (string.IsNullOrEmpty(Loc.Instance.CurrentLanguage))
                Loc.Instance.CurrentLanguage = _selectedLanguage;


            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabDefault",
                Header = Loc.Tr("TabDefault"),
                ContentViewModel = new DefaultBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabTwoWay",
                Header = Loc.Tr("TabTwoWay"),
                ContentViewModel = new TwoWaysBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabOneTime",
                Header = Loc.Tr("TabOneTime"),
                ContentViewModel = new OneTimeBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabOneWay",
                Header = Loc.Tr("TabOneWay"),
                ContentViewModel = new OneWayBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                LocalizationKey = "TabTriggers",
                Header = Loc.Tr("TabTriggers"),
                ContentViewModel = new TriggersViewModel()
            });

            Loc.Instance.CurrentLanguageChanged += (o, e) => UpdateTabHeaders();
        }

        partial void OnSelectedLanguageChanged(string value)
        {
            if (!string.IsNullOrEmpty(value))
                Loc.Instance.CurrentLanguage = value;
        }

        private void UpdateTabHeaders()
        {
            foreach (var tab in Tabs)
            {
                if (!string.IsNullOrEmpty(tab.LocalizationKey))
                    tab.Header = Loc.Tr(tab.LocalizationKey);
            }
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