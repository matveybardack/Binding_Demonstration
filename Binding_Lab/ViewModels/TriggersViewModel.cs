using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

namespace Binding_Lab.ViewModels;

public partial class TriggersViewModel : ObservableObject
{
    public MyLoc Localization => MyLoc.Instance;

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

    public TriggersViewModel()
    {
        Localization.PropertyChanged += (s, e) =>
        {
            DefaultTriggerText = Localization["TRtxtvmall"];
            PropertyChangedText = Localization["TRtxtvmall"];
            ExplicitText = Localization["TRtxtvmall"];
            LostFocusText = Localization["TRtxtvmall"];
        };
    }
}