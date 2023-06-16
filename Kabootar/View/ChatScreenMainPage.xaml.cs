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
        _viewModel.FocusEntry += ViewModel_FocusEntry;
    }

    private void ViewModel_FocusEntry(object sender, int e)
    {
        if (e == 0)
        {
            MessageEntryReple.Focus();
            NewMessageEntry.Unfocus();
        }
        else
        {
            MessageEntryReple.Unfocus();
            NewMessageEntry.Focus();
        }
    }

    private void ViewModel_FocusEntry(object sender, EventArgs e)
    {
        MessageEntryReple.Focus();
        NewMessageEntry.Unfocus();
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