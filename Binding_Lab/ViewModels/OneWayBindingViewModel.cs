using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

namespace Binding_Lab.ViewModels;

public partial class OneWayBindingViewModel : ObservableObject
{
    public LocalizationService loc = new();

    [ObservableProperty]
    private string _sourceText = "Источник данных";

    [ObservableProperty]
    private int _sourceValue = 75;

    public OneWayBindingViewModel()
    {
        LocalizationService.Instance.PropertyChanged += (s, e) =>
        {
            SourceText = loc["OWtxtvm1"];
        };
    }
}