using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Kabootar
{
    public partial class MessagesViewModel : ObservableObject
    {
        public event EventHandler<ChatDataModel> MoveToChat;

        [ObservableProperty]
        private ChatDataModel _chatDataModel;

        [ObservableProperty]
        private ObservableCollection<ChatDataModel> _chatList;

        private MessagesModel _messagesModel;

        [ObservableProperty]
        private bool _isRunning;

        [ObservableProperty]
        private bool _isVisible;

        [ObservableProperty]
        private bool _isRefreshing;

        public MessagesViewModel()
        {
            _messagesModel = new MessagesModel();
            SetData();
        }

        private async void SetData()
        {
            IsRunning = true;
            IsVisible = false;
            var result = await _messagesModel.PerformAction();
            if (result.IsSuccess)
            {
                ChatList = _messagesModel.ChatList.ToObservableCollection();
            }
            IsRunning = false;
            IsVisible = true;
        }

        [RelayCommand]
        private void OpenSelectedMessage(object chatData)
        {
            ChatDataModel chatdata = chatData as ChatDataModel;
            MoveToChat?.Invoke(this, chatdata);
        }

        [RelayCommand]
        private void Refresh()
        {
            IsRefreshing = true;
            SetData();
            IsRefreshing = false;
        }
    }
}