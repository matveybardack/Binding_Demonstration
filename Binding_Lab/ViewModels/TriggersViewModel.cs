using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class TriggersViewModel : ObservableObject
{
    [ObservableProperty]
    private string _defaultTriggerText = "DefaultTriggerText";

    [ObservableProperty]
    private string _propertyChangedText = "PropertyChangedText";

    [ObservableProperty]
    private string _explicitText = "ExplicitText";

    [ObservableProperty]
    private string _lostFocusText = "LostFocusText";

    [ObservableProperty]
    private int _sliderValue = 50;

    [ObservableProperty]
    private bool _checkBoxValue = false;
}