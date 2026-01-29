namespace Binding_Lab.ViewModels;

public class TwoWaysBindingViewModel : INotifyPropertyChanged
{
    private string _twoWayText = "Изменяемый текст";
    private double _twoWayValue = 50.0;
    private string _log = "";

    public string TwoWayText
    {
        get => _twoWayText;
        set { _twoWayText = value; OnPropertyChanged(); }
    }

    public double TwoWayValue
    {
        get => _twoWayValue;
        set { _twoWayValue = value; OnPropertyChanged(); }
    }

    public string Log
    {
        get => _log;
        set { _log = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
