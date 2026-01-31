using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class OneWayBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _sourceText = "Источник данных";

    [ObservableProperty]
    private int _sourceValue = 75;
}