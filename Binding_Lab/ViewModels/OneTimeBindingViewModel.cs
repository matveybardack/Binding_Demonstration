namespace Binding_Lab.ViewModels;

public class OneTimeBindingViewModel : INotifyPropertyChanged
{
    private string _initialText = "Текст только при инициализации";
    private int _initialNumber = 100;

    public string InitialText => _initialText;
    public int InitialNumber => _initialNumber;

    public OneTimeBindingViewModel()
    {
        _initialText = "Значение установлено в конструкторе";
        _initialNumber = 200;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
