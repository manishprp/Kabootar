namespace Kabootar;

public partial class MessagesMainPage : ContentPage
{
    private MessagesViewModel _viewModel;

    public MessagesMainPage()
    {
        InitializeComponent();
        _viewModel = (MessagesViewModel)BindingContext;
        _viewModel.MoveToChat += ViewModel_MoveToChat;
    }

    private async void ViewModel_MoveToChat(object sender, ChatDataModel e)
    {
        await Navigation.PushAsync(new ChatScreenMainPage()
        {
            BackgroundColor = Color.FromRgba("#FFFFFF"),
        });
    }
}