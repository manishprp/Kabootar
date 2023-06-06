namespace Kabootar;

public partial class ChatScreenMainPage : ContentPage
{
    private ChatPageViewModel _viewModel;

    public ChatScreenMainPage()
    {
        InitializeComponent();
        NavigationPage.SetHasBackButton(this, false);
        _viewModel = (ChatPageViewModel)BindingContext;
        _viewModel.NewMessage += ViewModel_NewMessage;
        _viewModel.MoveBackEvent += ViewModel_MoveBackEvent;
    }

    private void ViewModel_MoveBackEvent(object sender, EventArgs e)
    {
        OnBackButtonPressed();
    }

    private void ViewModel_NewMessage(object sender, int e)
    {
        ChatCollectionView.ScrollTo(e);
    }
}