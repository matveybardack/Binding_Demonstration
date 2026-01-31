using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class DefaultBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _defaultText = "Текст по умолчанию";

    [ObservableProperty]
    private int _defaultProgress = 42;

    [ObservableProperty]
    private bool _defaultFlag = true;
}