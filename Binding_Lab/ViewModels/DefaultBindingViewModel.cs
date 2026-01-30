namespace Binding_Lab.ViewModels;

public class DefaultBindingViewModel : INotifyPropertyChanged
{
    private string _defaultText = "Текст по умолчанию";
    private int _defaultprogress= 42;
    private bool _defaultFlag = true;

    public string DefaultText
    {
        get => _defaultText;
        set { _defaultText = value; OnPropertyChanged(); }
    }

    public int DefaultProgress
    {
        get => _defaultprogress;
        set { _defaultprogress = value; OnPropertyChanged(); }
    }

    public bool DefaultFlag
    {
        get => _defaultFlag;
        set { _defaultFlag = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
