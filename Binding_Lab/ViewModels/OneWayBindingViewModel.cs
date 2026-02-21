using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

namespace Binding_Lab.ViewModels;

public partial class OneWayBindingViewModel : ObservableObject
{
    public MyLoc Localization => MyLoc.Instance;

    [ObservableProperty]
    private string _sourceText = "Источник данных";

    [ObservableProperty]
    private int _sourceValue = 75;

    public OneWayBindingViewModel()
    {
        Localization.PropertyChanged += (s, e) =>
        {
            SourceText = Localization["OWBtxtvm1"];
        };
    }
}