using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class OneTimeBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _initialText = "Задано в конструкторе";

    [ObservableProperty]
    private int _initialNumber = 200;

    public int InitialNumberSquared => _initialNumber * _initialNumber;

    public OneTimeBindingViewModel()
    {
        // Оповещаем об инициализации вычисляемого свойства
        OnPropertyChanged(nameof(InitialNumberSquared));
    }
}