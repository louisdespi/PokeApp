using System.Runtime.CompilerServices;

namespace PokeApp.ViewModels;
public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {

    }
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(isNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool isNotBusy => !IsBusy;
}