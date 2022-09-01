using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Models.DboModels
{
    [Table("Messages")]
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid FromUserId { get; set; }
        [ForeignKey("FromUserId")]
        public User FromUser { get; set; }
        public Guid? ToUserId { get; set; }
        [ForeignKey("ToUserId")]
        public User ToUser { get; set; } = null;
        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group { get; set; } = null;
        public bool IsVisible { get; set; }
        public bool IsVisibleForOwner { get; set; }
        public Guid? ReplyMessageId { get; set; }
        [ForeignKey("ReplyMessageId")]
        public Message ReplyMessage { get; set; } = null;
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
