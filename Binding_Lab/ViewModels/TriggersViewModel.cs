namespace Binding_Lab.ViewModels;

public class TriggersViewModel : INotifyPropertyChanged
{
    private string _triggerText = "";
    private bool _isEnabled = true;
    private int _value = 0;

    public string TriggerText
    {
        get => _triggerText;
        set { _triggerText = value; OnPropertyChanged(); }
    }

    public bool IsEnabled
    {
        get => _isEnabled;
        set { _isEnabled = value; OnPropertyChanged(); }
    }

    public int Value
    {
        get => _value;
        set { _value = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
