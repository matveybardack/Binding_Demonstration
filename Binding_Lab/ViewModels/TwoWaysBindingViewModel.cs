using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class TwoWaysBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _twoWayText = "Изменяемый текст";

    [ObservableProperty]
    private int _twoWayValue = 50;

    [ObservableProperty]
    private bool _twoWayFlag = false;
}