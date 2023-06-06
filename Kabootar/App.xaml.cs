namespace Kabootar;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MessagesMainPage());
        //MainPage = new NavigationPage(new ChatScreenMainPage())
        //{
        //    BarBackgroundColor = Color.FromRgba("#FFFFFF"),
        //};
    }
}