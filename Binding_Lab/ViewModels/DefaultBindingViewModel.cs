using CommunityToolkit.Mvvm.ComponentModel;
using CodingSeb.Localization;

namespace Binding_Lab.ViewModels;

public partial class DefaultBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _defaultText = "Текст по умолчанию";
    private readonly string _defaultTextKey = "DBtxtvm1";

    [ObservableProperty]
    private int _defaultProgress = 42;

    [ObservableProperty]
    private bool _defaultFlag = true;

    public DefaultBindingViewModel()
    {
        Loc.Instance.CurrentLanguageChanged += (o, e) => DefaultText = Loc.Tr(_defaultTextKey);
    }
}