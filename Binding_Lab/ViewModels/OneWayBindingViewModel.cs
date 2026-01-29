namespace Binding_Lab.ViewModels;


public class OneWayBindingViewModel : INotifyPropertyChanged
{
    private string _sourceText = "Источник данных";
    private int _sourceValue = 75;
    private int _counter = 0;

    public string SourceText
    {
        get => _sourceText;
        set { _sourceText = value; OnPropertyChanged(); }
    }

    public int SourceValue
    {
        get => _sourceValue;
        set { _sourceValue = value; OnPropertyChanged(); }
    }

    public string DisplayText => $"Счетчик: {_counter}, Значение: {_sourceValue}";

    public void UpdateCounter()
    {
        _counter++;
        OnPropertyChanged(nameof(DisplayText));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
