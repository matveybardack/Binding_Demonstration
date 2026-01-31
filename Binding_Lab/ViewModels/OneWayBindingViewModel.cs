namespace Binding_Lab.ViewModels;


public class OneWayBindingViewModel : INotifyPropertyChanged
{
    private string _sourceText = "Источник данных";
    private int _sourceValue = 75;

    public string SourceText
    {
        get => _sourceText;
        set { _sourceText = value; OnPropertyChanged(); }
    }

    public int SourceValue
    {
        get => _sourceValue;
        set { 
            _sourceValue = value; 
            OnPropertyChanged(); 
        }
    }


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
