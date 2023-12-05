using mauitestapp.ViewModels;

namespace mauitestapp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new MainViewModel();
    }

    private void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
    {
        
    }
}


