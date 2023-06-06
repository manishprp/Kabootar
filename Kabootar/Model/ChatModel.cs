namespace Kabootar
{
    public class ChatModel
    {
        public List<ChatDataModel> ChatList { get; set; }

        public ChatModel()
        {
            ChatList = new List<ChatDataModel>();
        }

        public async Task<Result> PerformAction()
        {
            SetUpData();
            return new Result
            {
                IsSuccess = true,
                Message = "List fetched"
            };
        }

        private void SetUpData()
        {
            ChatList.Clear();
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = true });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = true });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = false });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = false });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = true });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = false });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = true });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = false });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = true });
            ChatList.Add(new ChatDataModel { ImageSource = "dotnet_bot", Message = "Hey there ! I am using Kabootarr.", Name = "Bheem", Time = "11:11", IsReceived = false });
        }
    }
}