namespace Chat.Models.DtoModels.Message
{
    public class GetMessagesResponse
    {
        public ICollection<AppMessage> Messages { get; set; }
    }
}
