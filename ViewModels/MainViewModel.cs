using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using mauitestapp.Pages;
using TabbedPage = Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific.TabbedPage;

namespace mauitestapp.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly static Dictionary<string, ContentPage> _pages = new()
    {
        { nameof(TabBarChatPage), new TabBarChatPage() },
        { nameof(TabBarContactsPage), new TabBarContactsPage() },
        { nameof(TabBarFindPage), new TabBarFindPage() },
        { nameof(TabBarSelfPage), new TabBarSelfPage() },
    };

    [ObservableProperty]
    private ContentPage _currentPage;
    
    [RelayCommand]
    private void OnSelected(string pageName)
    {
        CurrentPage = _pages[pageName];
    }
}