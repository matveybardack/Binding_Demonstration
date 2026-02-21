using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

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

    public LocalizationService loc = new();

    public TriggersViewModel()
    {
        LocalizationService.Instance.PropertyChanged += (s, e) =>
        {
            DefaultTriggerText = loc["TRtxtvmall"];
            PropertyChangedText = loc["TRtxtvmall"];
            ExplicitText = loc["TRtxtvmall"];
            LostFocusText = loc["TRtxtvmall"];
        };
    }
}