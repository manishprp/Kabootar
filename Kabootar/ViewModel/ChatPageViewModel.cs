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

        public event EventHandler MoveBackEvent;

        private ChatModel _chatModel;
        private bool _isRec;

        [ObservableProperty]
        private string _message;

        public ChatPageViewModel()
        {
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
            NewMessage?.Invoke(this, ChatDataModel.Count - 1);
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