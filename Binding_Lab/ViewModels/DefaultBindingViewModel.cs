using Binding_Lab.Resourse;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class DefaultBindingViewModel : ObservableObject
{
    public MyLoc Localization => MyLoc.Instance;

    [ObservableProperty]
    private string _defaultText = "Текст по умолчанию";

    [ObservableProperty]
    private int _defaultProgress = 42;

    [ObservableProperty]
    private bool _defaultFlag = true;

    public DefaultBindingViewModel()
    {
        Localization.PropertyChanged += (s, e) =>
        {
            DefaultText = Localization["DBtxtvm1"];
        };
    }
}