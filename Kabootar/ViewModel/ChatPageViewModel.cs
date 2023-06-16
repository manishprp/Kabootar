using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Kabootar
{
    public partial class ChatPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ChatDataModel> _chatDataModel;

        public event EventHandler<int> NewMessage;

        public event EventHandler<int> FocusEntry;

        public event EventHandler MoveBackEvent;

        [ObservableProperty]
        private string _sender;

        [ObservableProperty]
        private string _swipedMessage;

        [ObservableProperty]
        private ChatModel _chatModel;

        private bool _isRec;

        [ObservableProperty]
        private bool _isReplyVisible;

        [ObservableProperty]
        private bool _isNewMessageVisible;

        [ObservableProperty]
        private string _message;

        public ChatPageViewModel()
        {
            IsReplyVisible = false;
            IsNewMessageVisible = true;
            _isRec = true;
            _chatModel = new ChatModel();
            SetMainData();
        }

        [RelayCommand]
        private void MoveBack()
        {
            MoveBackEvent?.Invoke(this, EventArgs.Empty);
        }

        [RelayCommand]
        private void SendMessage()
        {
            var newChat = new ChatDataModel();
            newChat.Message = Message;
            Message = string.Empty;
            newChat.ImageSource = "dotnet_bot";
            newChat.IsReceived = _isRec;
            _isRec = !_isRec;
            newChat.Time = "7:30 PM";
            ChatDataModel.Add(newChat);
            IsReplyVisible = false;
            IsNewMessageVisible = true;
            NewMessage?.Invoke(this, ChatDataModel.Count - 1);
        }

        [RelayCommand]
        private void CancelReply()
        {
            IsReplyVisible = false;
            IsNewMessageVisible = true;
            FocusEntry?.Invoke(this, 1);
        }

        [RelayCommand]
        private void Reply(object item)
        {
            var newChat = item as ChatDataModel;

            IsReplyVisible = true;
            IsNewMessageVisible = false;
            Sender = newChat.Name;
            SwipedMessage = newChat.Message;
            FocusEntry?.Invoke(this, 0);
        }

        private async void SetMainData()
        {
            var result = await _chatModel.PerformAction();
            if (result.IsSuccess)
            {
                ChatDataModel = _chatModel.ChatList.ToObservableCollection();
            }
        }
    }
}