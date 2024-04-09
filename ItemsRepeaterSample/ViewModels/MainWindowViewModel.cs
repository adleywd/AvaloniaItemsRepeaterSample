using CommunityToolkit.Mvvm.ComponentModel;

namespace ItemsRepeaterSample.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase _contentViewModel = default!;

    public TabbedViewModel TabbedContent { get; }
    
    public MainWindowViewModel()
    {
        TabbedContent = new TabbedViewModel();
        ContentViewModel = TabbedContent;
    }
   
}