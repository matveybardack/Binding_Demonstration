namespace Binding_Lab.ViewModels;

public class TriggersViewModel : INotifyPropertyChanged
{
    private string _defaultTriggerText = "DefaultTriggerText";
    private string _propertyChangedText = "PropertyChangedText";
    private string _explicitText = "ExplicitText";
    private string _lostFocusText = "LostFocusText";
    private int _sliderValue = 50;
    private bool _checkBoxValue = false;

    public bool CheckBoxValue
    {
        get => _checkBoxValue;
        set { _checkBoxValue = value; OnPropertyChanged(); }
    }

    public int SliderValue
    {
        get => _sliderValue;
        set { _sliderValue = value; OnPropertyChanged(); }
    }

    public string LostFocusText
    {
        get => _lostFocusText;
        set { _lostFocusText = value; OnPropertyChanged(); }
    }

    public string ExplicitText
    {
        get => _explicitText;
        set { _explicitText = value; OnPropertyChanged(); }
    }

    public string PropertyChangedText
    {
        get => _propertyChangedText;
        set { _propertyChangedText = value; OnPropertyChanged(); }
    }

    public string DefaultTriggerText
    {
        get => _defaultTriggerText;
        set { _defaultTriggerText = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
