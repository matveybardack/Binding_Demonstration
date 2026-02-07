using CodingSeb.Localization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Binding_Lab.ViewModels;

public partial class OneTimeBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string _initialText = "Задано в конструкторе";   
    private readonly string _initialTextKey = "OTBtxtvm1";

    [ObservableProperty]
    private int _initialNumber = 200;
    
    public int InitialNumberSquared => _initialNumber * _initialNumber;

    public OneTimeBindingViewModel()
    {
        // Оповещаем об инициализации вычисляемого свойства
        OnPropertyChanged(nameof(InitialNumberSquared));
        Loc.Instance.CurrentLanguageChanged += (o, e) => InitialText = Loc.Tr(_initialTextKey);
    }
}