using CodingSeb.Localization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class TwoWaysBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _twoWayText = "Изменяемый текст";
    private readonly string _twoWayTextKey = "TWtxtvm1";

    [ObservableProperty]
    private int _twoWayValue = 50;

    [ObservableProperty]
    private bool _twoWayFlag = false;

    public TwoWaysBindingViewModel()
    {
        Loc.Instance.CurrentLanguageChanged += (o, e) => TwoWayText = Loc.Tr(_twoWayTextKey);
    }
}