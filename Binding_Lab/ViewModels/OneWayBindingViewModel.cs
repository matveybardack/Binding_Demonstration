using CodingSeb.Localization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class OneWayBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _sourceText = "Источник данных";
    private readonly string _sourceTextKey = "OWtxtvm1";

    [ObservableProperty]
    private int _sourceValue = 75;

    public OneWayBindingViewModel()
    {
        Loc.Instance.CurrentLanguageChanged += (o, e) => SourceText = Loc.Tr(_sourceTextKey);
    }
}