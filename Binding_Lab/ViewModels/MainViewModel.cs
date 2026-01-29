global using System.ComponentModel;
global using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Binding_Lab.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<TabItemViewModel> Tabs { get; } = new();

        public MainViewModel()
        {
            Tabs.Add(new TabItemViewModel
            {
                Header = "Привязка по умолчанию",
                ContentViewModel = new DefaultBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                Header = "Двухсторонняя привязка",
                ContentViewModel = new TwoWaysBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                Header = "Одноразовая привязка",
                ContentViewModel = new OneTimeBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                Header = "Односторонняя привязка",
                ContentViewModel = new OneWayBindingViewModel()
            });

            Tabs.Add(new TabItemViewModel
            {
                Header = "Триггеры",
                ContentViewModel = new TriggersViewModel()
            });
        }
    }

    public class TabItemViewModel
    {
        public string Header { get; set; }
        public object ContentViewModel { get; set; }
    }
}