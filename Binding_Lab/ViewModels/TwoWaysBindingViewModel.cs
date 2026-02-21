using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

namespace Binding_Lab.ViewModels;

public partial class TwoWaysBindingViewModel : ObservableObject
{
    public MyLoc Localization => MyLoc.Instance;

    [ObservableProperty]
    private string _twoWayText = "Изменяемый текст";

    [ObservableProperty]
    private int _twoWayValue = 50;

    [ObservableProperty]
    private bool _twoWayFlag = false;

    public TwoWaysBindingViewModel()
    {
        Localization.PropertyChanged += (s, e) =>
        {
            TwoWayText = Localization["TWBtxtvm1"];
        };
    }
}