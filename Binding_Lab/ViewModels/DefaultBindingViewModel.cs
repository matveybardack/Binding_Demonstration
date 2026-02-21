using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

namespace Binding_Lab.ViewModels;

public partial class DefaultBindingViewModel : ObservableObject
{
    public LocalizationService loc = new();

    [ObservableProperty]
    private string _defaultText = "Текст по умолчанию";

    [ObservableProperty]
    private int _defaultProgress = 42;

    [ObservableProperty]
    private bool _defaultFlag = true;

    public DefaultBindingViewModel()
    {
        LocalizationService.Instance.PropertyChanged += (s, e) =>
        {
            DefaultText = loc["DBtxtvm1"];
        };
    }
}