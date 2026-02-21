using Binding_Lab.Resourse;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class OneTimeBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _initialText = "Задано в конструкторе";

    [ObservableProperty]
    private int _initialNumber = 200;

    public MyLoc Localization => MyLoc.Instance;


    public int InitialNumberSquared => _initialNumber * _initialNumber;

    public OneTimeBindingViewModel()
    {
        // Оповещаем об инициализации вычисляемого свойства
        OnPropertyChanged(nameof(InitialNumberSquared));

        Localization.PropertyChanged += (s, e) =>
        {
            InitialText = Localization["OTBtxtvm1"];
        };
    }
}