using CommunityToolkit.Mvvm.ComponentModel;
using Binding_Lab.Resourse;

namespace Binding_Lab.ViewModels;

public partial class OneTimeBindingViewModel : ObservableObject
{
    public LocalizationService loc = new();

    [ObservableProperty]
    private string _initialText = "Задано в конструкторе";

    [ObservableProperty]
    private int _initialNumber = 200;

    public int InitialNumberSquared => _initialNumber * _initialNumber;

    public OneTimeBindingViewModel()
    {
        // Оповещаем об инициализации вычисляемого свойства
        OnPropertyChanged(nameof(InitialNumberSquared));

        LocalizationService.Instance.PropertyChanged += (s, e) =>
        {
            InitialText = loc["OTBtxtvm1"];
        };
    }
}