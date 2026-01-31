namespace Binding_Lab.ViewModels;

public class OneTimeBindingViewModel : INotifyPropertyChanged
{
    private string _initialText = "";
    private int _initialNumber = 100;
    private int _initialNumberSquared = 0;

    public string InitialText
    {
        get => _initialText;
        set { _initialText = value; OnPropertyChanged(); }
    }
    public int InitialNumber
    {
        get => _initialNumber;
        set { _initialNumber = value; OnPropertyChanged(); }
    }

    public int InitialNumberSquared
    {
        get => _initialNumberSquared;
        set { _initialNumberSquared = value*value; OnPropertyChanged(); }
    }

    public OneTimeBindingViewModel()
    {
        _initialText = "Задано в конструкторе";
        _initialNumber = 200;
        _initialNumberSquared = _initialNumber * _initialNumber;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
