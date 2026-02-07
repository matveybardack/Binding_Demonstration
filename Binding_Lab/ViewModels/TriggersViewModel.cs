using CodingSeb.Localization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class TriggersViewModel : ObservableObject
{
    private readonly string _defaultTriggerTextKey = "TRtxtvmall";

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
        Loc.Instance.CurrentLanguageChanged += (o, e) => OnLanguageChanged();
    }

    private void OnLanguageChanged()
    {
        DefaultTriggerText = Loc.Tr(_defaultTriggerTextKey);
        PropertyChangedText = Loc.Tr(_defaultTriggerTextKey);
        ExplicitText = Loc.Tr(_defaultTriggerTextKey);
        LostFocusText = Loc.Tr(_defaultTriggerTextKey);
    }
}