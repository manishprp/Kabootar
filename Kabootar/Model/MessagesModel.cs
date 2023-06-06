namespace Kabootar
{
    public class MessagesModel
    {
        public List<ChatDataModel> ChatList { get; set; }

        public MessagesModel()
        {
            ChatList = new List<ChatDataModel>();
        }

        public async Task<Result> PerformAction()
        {
            await Task.Delay(1500);
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